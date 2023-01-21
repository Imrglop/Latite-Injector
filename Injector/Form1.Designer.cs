
namespace Injector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DragPanel = new System.Windows.Forms.Panel();
            this.XButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FadeWorker = new System.ComponentModel.BackgroundWorker();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            this.Downloader = new System.ComponentModel.BackgroundWorker();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.Updater = new System.ComponentModel.BackgroundWorker();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.VersionPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.DragPanel.Controls.Add(this.XButton);
            this.DragPanel.Controls.Add(this.label1);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(699, 55);
            this.DragPanel.TabIndex = 0;
            this.DragPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DragPanel_Paint);
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.XButton.FlatAppearance.BorderSize = 0;
            this.XButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.XButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(642, 4);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(54, 48);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latite Client";
            // 
            // FadeWorker
            // 
            this.FadeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FadeWorker_DoWork);
            // 
            // LaunchButton
            // 
            this.LaunchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.LaunchButton.FlatAppearance.BorderSize = 0;
            this.LaunchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.LaunchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchButton.ForeColor = System.Drawing.Color.White;
            this.LaunchButton.Location = new System.Drawing.Point(262, 221);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(175, 83);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = false;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.BackColor = System.Drawing.Color.Transparent;
            this.StatusText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.Color.White;
            this.StatusText.Location = new System.Drawing.Point(12, 437);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(110, 23);
            this.StatusText.TabIndex = 3;
            this.StatusText.Text = "Not injected";
            // 
            // Downloader
            // 
            this.Downloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Downloader_DoWork);
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.BackColor = System.Drawing.Color.Transparent;
            this.AutoStart.Checked = true;
            this.AutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoStart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.AutoStart.ForeColor = System.Drawing.Color.White;
            this.AutoStart.Location = new System.Drawing.Point(588, 63);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(99, 23);
            this.AutoStart.TabIndex = 4;
            this.AutoStart.Text = "Auto start";
            this.AutoStart.UseVisualStyleBackColor = false;
            // 
            // Updater
            // 
            this.Updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Updater_DoWork);
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.UpdateLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateLabel.Location = new System.Drawing.Point(89, 89);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(67, 19);
            this.UpdateLabel.TabIndex = 5;
            this.UpdateLabel.Text = "Loading";
            // 
            // VersionPanel
            // 
            this.VersionPanel.BackColor = System.Drawing.Color.Transparent;
            this.VersionPanel.Location = new System.Drawing.Point(16, 137);
            this.VersionPanel.Name = "VersionPanel";
            this.VersionPanel.Size = new System.Drawing.Size(194, 265);
            this.VersionPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Injector.Properties.Resources.LatiteClient_Small;
            this.pictureBox1.Location = new System.Drawing.Point(15, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::Injector.Properties.Resources.BG_DS;
            this.ClientSize = new System.Drawing.Size(699, 469);
            this.Controls.Add(this.VersionPanel);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DragPanel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latite Injector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.ComponentModel.BackgroundWorker FadeWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Label StatusText;
        private System.ComponentModel.BackgroundWorker Downloader;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.ComponentModel.BackgroundWorker Updater;
        private System.Windows.Forms.Label UpdateLabel;
        private System.Windows.Forms.Panel VersionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

