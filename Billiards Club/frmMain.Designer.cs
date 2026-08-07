namespace Billiards_Club
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            inactivePlayersToolStripMenuItem = new ToolStripMenuItem();
            managePlayersToolStripMenuItem = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            SignOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 25, 52);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._8_ball;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1431, 691);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Lavender;
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, usersToolStripMenuItem, playersToolStripMenuItem, tablesToolStripMenuItem, accountSettingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 619);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1431, 72);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Image = Properties.Resources.People_641;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(221, 68);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Image = Properties.Resources.users_64;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(197, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inactivePlayersToolStripMenuItem, managePlayersToolStripMenuItem });
            playersToolStripMenuItem.Image = Properties.Resources.team;
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(180, 68);
            playersToolStripMenuItem.Text = "Players";
            // 
            // inactivePlayersToolStripMenuItem
            // 
            inactivePlayersToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            inactivePlayersToolStripMenuItem.Image = Properties.Resources.Delete_32;
            inactivePlayersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            inactivePlayersToolStripMenuItem.Name = "inactivePlayersToolStripMenuItem";
            inactivePlayersToolStripMenuItem.Size = new Size(364, 50);
            inactivePlayersToolStripMenuItem.Text = "Inactive Players";
            inactivePlayersToolStripMenuItem.Click += inactivePlayersToolStripMenuItem_Click;
            // 
            // managePlayersToolStripMenuItem
            // 
            managePlayersToolStripMenuItem.Font = new Font("Segoe UI", 20F);
            managePlayersToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            managePlayersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            managePlayersToolStripMenuItem.Name = "managePlayersToolStripMenuItem";
            managePlayersToolStripMenuItem.Size = new Size(364, 50);
            managePlayersToolStripMenuItem.Text = "Manage Players";
            managePlayersToolStripMenuItem.Click += managePlayersToolStripMenuItem_Click;
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(146, 68);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SignOutToolStripMenuItem, toolStripMenuItem1, changePasswordToolStripMenuItem, currentUserInfoToolStripMenuItem });
            accountSettingsToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(401, 68);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // SignOutToolStripMenuItem
            // 
            SignOutToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            SignOutToolStripMenuItem.Image = Properties.Resources.sign_out_32__2;
            SignOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            SignOutToolStripMenuItem.Size = new Size(273, 38);
            SignOutToolStripMenuItem.Text = "Sign Out";
            SignOutToolStripMenuItem.Click += SignOutToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(270, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(273, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            currentUserInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(273, 38);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1431, 691);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main ";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private ToolStripMenuItem SignOutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem inactivePlayersToolStripMenuItem;
        private ToolStripMenuItem managePlayersToolStripMenuItem;
    }
}