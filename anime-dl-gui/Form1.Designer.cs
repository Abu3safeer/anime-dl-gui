namespace anime_dl_gui
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.URLLabel = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SaveAccountButton = new System.Windows.Forms.Button();
            this.AccountBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Information = new System.Windows.Forms.ToolTip(this.components);
            this.Resolution = new System.Windows.Forms.ComboBox();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubtitleOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EpisodeFrom = new System.Windows.Forms.TextBox();
            this.EpisodeTo = new System.Windows.Forms.TextBox();
            this.Verbose = new System.Windows.Forms.CheckBox();
            this.Episodes = new System.Windows.Forms.CheckBox();
            this.AccountBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(12, 18);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(30, 13);
            this.URLLabel.TabIndex = 0;
            this.URLLabel.Text = "URL:";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(48, 15);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(506, 20);
            this.URL.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 26);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(59, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Location = new System.Drawing.Point(6, 61);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(57, 13);
            this.PaswordLabel.TabIndex = 3;
            this.PaswordLabel.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(69, 23);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(122, 20);
            this.Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(69, 58);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(122, 20);
            this.Password.TabIndex = 5;
            this.Password.UseSystemPasswordChar = true;
            // 
            // SaveAccountButton
            // 
            this.SaveAccountButton.Location = new System.Drawing.Point(209, 19);
            this.SaveAccountButton.Name = "SaveAccountButton";
            this.SaveAccountButton.Size = new System.Drawing.Size(115, 24);
            this.SaveAccountButton.TabIndex = 6;
            this.SaveAccountButton.Text = "Save";
            this.SaveAccountButton.UseVisualStyleBackColor = true;
            this.SaveAccountButton.Click += new System.EventHandler(this.SaveAccountButton_Click);
            // 
            // AccountBox
            // 
            this.AccountBox.Controls.Add(this.linkLabel1);
            this.AccountBox.Controls.Add(this.ShowPassword);
            this.AccountBox.Controls.Add(this.Username);
            this.AccountBox.Controls.Add(this.SaveAccountButton);
            this.AccountBox.Controls.Add(this.UsernameLabel);
            this.AccountBox.Controls.Add(this.PaswordLabel);
            this.AccountBox.Controls.Add(this.Password);
            this.AccountBox.Location = new System.Drawing.Point(215, 41);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(339, 88);
            this.AccountBox.TabIndex = 7;
            this.AccountBox.TabStop = false;
            this.AccountBox.Text = "Account";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(312, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(12, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.Information.SetToolTip(this.linkLabel1, "Data are saved in plain text, make sure your pc is secure.");
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(209, 61);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(106, 17);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Show password?";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Information
            // 
            this.Information.AutomaticDelay = 10;
            this.Information.AutoPopDelay = 20000;
            this.Information.InitialDelay = 10;
            this.Information.IsBalloon = true;
            this.Information.ReshowDelay = 2;
            // 
            // Resolution
            // 
            this.Resolution.DisplayMember = "1080p";
            this.Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resolution.FormattingEnabled = true;
            this.Resolution.Items.AddRange(new object[] {
            "1080p",
            "720p",
            "480p",
            "360p"});
            this.Resolution.Location = new System.Drawing.Point(78, 18);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(95, 21);
            this.Resolution.TabIndex = 8;
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(11, 21);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(61, 13);
            this.ResolutionLabel.TabIndex = 9;
            this.ResolutionLabel.Text = "Resolution:";
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(215, 135);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(339, 61);
            this.Execute.TabIndex = 10;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Episodes);
            this.groupBox1.Controls.Add(this.Verbose);
            this.groupBox1.Controls.Add(this.EpisodeTo);
            this.groupBox1.Controls.Add(this.EpisodeFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SubtitleOnly);
            this.groupBox1.Controls.Add(this.ResolutionLabel);
            this.groupBox1.Controls.Add(this.Resolution);
            this.groupBox1.Location = new System.Drawing.Point(10, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 157);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "From:";
            // 
            // SubtitleOnly
            // 
            this.SubtitleOnly.AutoSize = true;
            this.SubtitleOnly.Location = new System.Drawing.Point(14, 45);
            this.SubtitleOnly.Name = "SubtitleOnly";
            this.SubtitleOnly.Size = new System.Drawing.Size(90, 17);
            this.SubtitleOnly.TabIndex = 11;
            this.SubtitleOnly.Text = "Subtitles only";
            this.Information.SetToolTip(this.SubtitleOnly, "Skip video downloads (Will only download subtitles)");
            this.SubtitleOnly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "To:";
            // 
            // EpisodeFrom
            // 
            this.EpisodeFrom.Location = new System.Drawing.Point(78, 103);
            this.EpisodeFrom.Name = "EpisodeFrom";
            this.EpisodeFrom.ReadOnly = true;
            this.EpisodeFrom.Size = new System.Drawing.Size(95, 20);
            this.EpisodeFrom.TabIndex = 14;
            // 
            // EpisodeTo
            // 
            this.EpisodeTo.Location = new System.Drawing.Point(78, 129);
            this.EpisodeTo.Name = "EpisodeTo";
            this.EpisodeTo.ReadOnly = true;
            this.EpisodeTo.Size = new System.Drawing.Size(95, 20);
            this.EpisodeTo.TabIndex = 15;
            // 
            // Verbose
            // 
            this.Verbose.AutoSize = true;
            this.Verbose.Location = new System.Drawing.Point(108, 45);
            this.Verbose.Name = "Verbose";
            this.Verbose.Size = new System.Drawing.Size(65, 17);
            this.Verbose.TabIndex = 17;
            this.Verbose.Text = "Verbose";
            this.Information.SetToolTip(this.Verbose, "Starts Verbose Logging for detailed information.");
            this.Verbose.UseVisualStyleBackColor = true;
            // 
            // Episodes
            // 
            this.Episodes.AutoSize = true;
            this.Episodes.Location = new System.Drawing.Point(14, 80);
            this.Episodes.Name = "Episodes";
            this.Episodes.Size = new System.Drawing.Size(73, 17);
            this.Episodes.TabIndex = 18;
            this.Episodes.Text = "Episodes?";
            this.Information.SetToolTip(this.Episodes, "Selects the range of episodes to download (Default = All)");
            this.Episodes.UseVisualStyleBackColor = true;
            this.Episodes.CheckedChanged += new System.EventHandler(this.Episodes_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.URLLabel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime-dl-gui";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AccountBox.ResumeLayout(false);
            this.AccountBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SaveAccountButton;
        private System.Windows.Forms.GroupBox AccountBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.ToolTip Information;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.ComboBox Resolution;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SubtitleOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EpisodeTo;
        private System.Windows.Forms.TextBox EpisodeFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Verbose;
        private System.Windows.Forms.CheckBox Episodes;
    }
}

