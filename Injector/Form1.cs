// github.com/Imrglop
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Diagnostics;
using System.Collections.Generic;

namespace Injector
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private bool Dragging = false;
        private float Fade = 0.0f;
        private WebClient client;
        private static int CurrentInjectorVersion = 2;
        private int latestInjectorVersion = 0;
        private List<GameVersion> versionList = new List<GameVersion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DragPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                int mx = MousePosition.X - (Width / 2);
                int my = MousePosition.Y - (DragPanel.Height / 2);
                SetDesktopLocation(mx, my);
            }
        }

        private void FadeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Fade < 1)
            {
                Fade += 0.03f;
                if (Fade > 1.0f)
                {
                    Fade = 1.0f;
                }
                Opacity = Fade;
                Thread.Sleep(20);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            Updater.RunWorkerAsync();
            FadeWorker.RunWorkerAsync();
            DoVersionManager();
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (!Downloader.IsBusy)
            {
                Downloader.RunWorkerAsync(); // run the downloader
            }
            else
            {
                MessageBox.Show("Already injecting!");
            }
        }

        private void SetStatus(string stat)
        {
            StatusText.Text = stat;
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message);
            SetStatus(message);
        }

        private GameVersion GetSelectedGameVersion()
        {
            foreach (RadioButton btn in VersionPanel.Controls)
            {
                foreach (var vers in versionList)
                {
                    if (btn.Name == vers.formatted && btn.Checked)
                    {
                        return vers;
                    }
                }
            }
            return null;
        }

        private void Downloader_DoWork(object sender, DoWorkEventArgs e)
        {
            string latest = client.DownloadString("https://raw.githubusercontent.com/Imrglop/Latite-Releases/main/latest_version.txt");
            string chosenVersion = GetSelectedGameVersion().raw;
            string dllPath = Path.GetTempPath() + $"Latite-{latest}-{chosenVersion}.dll";
            if (!File.Exists(dllPath)) // Check if we actually need to download the file
            {
                foreach (var file in Directory.GetFiles(Path.GetTempPath()))
                {
                    var fil = file.Substring(Path.GetTempPath().Length);
                    if (fil.StartsWith("Latite-") && fil.EndsWith(chosenVersion + ".dll"))
                    {
                        File.Delete(file);
                    }
                }
                SetStatus("Downloading " + latest + " for Minecraft " + chosenVersion);
                string url = $"https://github.com/Imrglop/Latite-Releases/releases/download/{latest}/Latite.{chosenVersion}.dll";
                client.DownloadFile(url, dllPath);
            }

            if (AutoStart.Checked)
                if (Process.GetProcessesByName("Minecraft.Windows").Length == 0)
                {
                    Process.Start("minecraft:");
                }

            FileInfo fileInfo = new FileInfo(dllPath);
            var ac = fileInfo.GetAccessControl();
            SetStatus("Injecting..");
            try
            {
                ac.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"),
                    FileSystemRights.FullControl, InheritanceFlags.None,
                    PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                fileInfo.SetAccessControl(ac);
            }
            catch (Exception)
            {
                ErrorMessage("Could not inject Latite! Try running the injector as administrator. (check 1)");
                return;
            }

            if (!Injector.Inject(dllPath, "Minecraft.Windows"))
            {
                SetStatus("Could not inject! " + dllPath);
                return;
            }

            SetStatus("Injected!");
        }

        private void Updater_DoWork(object sender, DoWorkEventArgs e)
        {
            string latestInj;
            try
            {
                latestInj = client.DownloadString("https://raw.githubusercontent.com/Imrglop/Latite-Releases/main/launcher_version");
            }
            catch (Exception)
            {
                ErrorMessage("Could not fetch latest version. Are you connected to the internet?");
                return;
            }

            latestInjectorVersion = Convert.ToInt32(latestInj);
            if (latestInjectorVersion == 0)
            {
                ErrorMessage("Invalid latest injector version!");
                return;
            }

            if (CurrentInjectorVersion != latestInjectorVersion)
            {
                UpdateLabel.Text = "Outdated launcher!";
                UpdateLabel.ForeColor = Color.Red;
                var res = MessageBox.Show(null, "Outdated launcher! Do you want to install the new version?", "Latite", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    string fn = "Injector_" + latestInjectorVersion + ".exe";
                    string path = "./" + fn;
                    if (File.Exists(path))
                        File.Delete(path);
                    client.DownloadFile("https://github.com/Imrglop/Latite-Releases/raw/main/injector/Injector.exe", path);
                    // Launch the new injector
                    Process.Start(fn);
                    Close();
                }
            }
            else
            {
                UpdateLabel.Text = "You are up to date";
                UpdateLabel.ForeColor = Color.White;
            }
        }

        private class GameVersion
        {
            public string raw = "";
            public string formatted = "";

            public GameVersion(string line)
            {
                raw = line;
                formatted = line.Replace('.', '_');
            }
        }

        private void DoVersionManager()
        {
            WebClient client = new WebClient();
            string versionListRaw;
            try
            {
                versionListRaw = client.DownloadString("https://raw.githubusercontent.com/Imrglop/Latite-Releases/main/game_versions");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Could not fetch version list: " + ee.ToString());
                return;
            }
            foreach (var line in versionListRaw.Replace("\r", "").Split('\n'))
            {
                versionList.Add(new GameVersion(line));
            }

            int curVersion = 0;
            foreach (var version in versionList)
            {
                var btn = new RadioButton();
                btn.Location = new Point(5, curVersion * 36);
                btn.Text = version.raw;
                btn.AutoSize = true;
                VersionPanel.Controls.Add(btn);
                btn.Name = version.formatted;
                btn.ForeColor = Color.White;
                if (curVersion == 0) btn.Checked = true;
                curVersion++;
            }
        }
    }
}