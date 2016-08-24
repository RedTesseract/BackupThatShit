namespace BackupThatShit2
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRedFolder = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbrFolders = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbTimerFolder = new System.Windows.Forms.GroupBox();
            this.gbFTPTimer = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.nmbrFolderTimer = new System.Windows.Forms.NumericUpDown();
            this.nmbrFtpTimer = new System.Windows.Forms.NumericUpDown();
            this.cbFtpTimer = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbRedFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFolders)).BeginInit();
            this.gbTarget.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbTimerFolder.SuspendLayout();
            this.gbFTPTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFolderTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFtpTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.gbRedFolder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gbTarget);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Folders";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRedFolder
            // 
            this.gbRedFolder.Controls.Add(this.label2);
            this.gbRedFolder.Controls.Add(this.nmbrFolders);
            this.gbRedFolder.Location = new System.Drawing.Point(8, 176);
            this.gbRedFolder.Name = "gbRedFolder";
            this.gbRedFolder.Size = new System.Drawing.Size(368, 59);
            this.gbRedFolder.TabIndex = 1;
            this.gbRedFolder.TabStop = false;
            this.gbRedFolder.Text = "Redundancy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of backups:";
            // 
            // nmbrFolders
            // 
            this.nmbrFolders.Location = new System.Drawing.Point(176, 23);
            this.nmbrFolders.Name = "nmbrFolders";
            this.nmbrFolders.Size = new System.Drawing.Size(120, 20);
            this.nmbrFolders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.tbDir);
            this.gbTarget.Controls.Add(this.btnDir);
            this.gbTarget.Controls.Add(this.label3);
            this.gbTarget.Location = new System.Drawing.Point(8, 46);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(368, 113);
            this.gbTarget.TabIndex = 0;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target directory";
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(176, 33);
            this.tbDir.Name = "tbDir";
            this.tbDir.ReadOnly = true;
            this.tbDir.Size = new System.Drawing.Size(100, 20);
            this.tbDir.TabIndex = 3;
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(122, 78);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(96, 23);
            this.btnDir.TabIndex = 2;
            this.btnDir.Text = "Choose directory";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current directory:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FTP";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbFTPTimer);
            this.tabPage3.Controls.Add(this.gbTimerFolder);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(384, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timed Backup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Folder backup enabled?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbTimerFolder
            // 
            this.gbTimerFolder.Controls.Add(this.nmbrFolderTimer);
            this.gbTimerFolder.Controls.Add(this.checkBox2);
            this.gbTimerFolder.Location = new System.Drawing.Point(8, 17);
            this.gbTimerFolder.Name = "gbTimerFolder";
            this.gbTimerFolder.Size = new System.Drawing.Size(368, 100);
            this.gbTimerFolder.TabIndex = 0;
            this.gbTimerFolder.TabStop = false;
            this.gbTimerFolder.Text = "Folder Timer";
            // 
            // gbFTPTimer
            // 
            this.gbFTPTimer.Controls.Add(this.nmbrFtpTimer);
            this.gbFTPTimer.Controls.Add(this.cbFtpTimer);
            this.gbFTPTimer.Location = new System.Drawing.Point(8, 123);
            this.gbFTPTimer.Name = "gbFTPTimer";
            this.gbFTPTimer.Size = new System.Drawing.Size(368, 100);
            this.gbFTPTimer.TabIndex = 1;
            this.gbFTPTimer.TabStop = false;
            this.gbFTPTimer.Text = "FTP Timer";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Enabled";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // nmbrFolderTimer
            // 
            this.nmbrFolderTimer.Location = new System.Drawing.Point(36, 58);
            this.nmbrFolderTimer.Name = "nmbrFolderTimer";
            this.nmbrFolderTimer.Size = new System.Drawing.Size(120, 20);
            this.nmbrFolderTimer.TabIndex = 1;
            // 
            // nmbrFtpTimer
            // 
            this.nmbrFtpTimer.Location = new System.Drawing.Point(36, 59);
            this.nmbrFtpTimer.Name = "nmbrFtpTimer";
            this.nmbrFtpTimer.Size = new System.Drawing.Size(120, 20);
            this.nmbrFtpTimer.TabIndex = 3;
            // 
            // cbFtpTimer
            // 
            this.cbFtpTimer.AutoSize = true;
            this.cbFtpTimer.Location = new System.Drawing.Point(36, 36);
            this.cbFtpTimer.Name = "cbFtpTimer";
            this.cbFtpTimer.Size = new System.Drawing.Size(65, 17);
            this.cbFtpTimer.TabIndex = 2;
            this.cbFtpTimer.Text = "Enabled";
            this.cbFtpTimer.UseVisualStyleBackColor = true;
            this.cbFtpTimer.CheckedChanged += new System.EventHandler(this.cbFtpTimer_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 367);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbRedFolder.ResumeLayout(false);
            this.gbRedFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFolders)).EndInit();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbTimerFolder.ResumeLayout(false);
            this.gbTimerFolder.PerformLayout();
            this.gbFTPTimer.ResumeLayout(false);
            this.gbFTPTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFolderTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrFtpTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.GroupBox gbRedFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbrFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbTimerFolder;
        private System.Windows.Forms.GroupBox gbFTPTimer;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown nmbrFolderTimer;
        private System.Windows.Forms.NumericUpDown nmbrFtpTimer;
        private System.Windows.Forms.CheckBox cbFtpTimer;
    }
}