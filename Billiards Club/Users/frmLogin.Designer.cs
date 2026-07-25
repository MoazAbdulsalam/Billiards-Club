namespace Billiards_Club.Users
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ccTextBoxUserName = new Billiards_Club.People.CustomControl.ccTextBox();
            ccTextBoxPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            chbRememberMe = new CheckBox();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SlateBlue;
            btnClose.Image = Properties.Resources.closeBlack32;
            btnClose.Location = new Point(791, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 43);
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(548, 56);
            label1.Name = "label1";
            label1.Size = new Size(123, 50);
            label1.TabIndex = 1;
            label1.Text = "Login ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(418, 160);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 2;
            label2.Text = "UserName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(428, 213);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // ccTextBoxUserName
            // 
            ccTextBoxUserName.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxUserName.IsRequired = false;
            ccTextBoxUserName.Location = new Point(573, 164);
            ccTextBoxUserName.Name = "ccTextBoxUserName";
            ccTextBoxUserName.Size = new Size(261, 27);
            ccTextBoxUserName.TabIndex = 0;
            // 
            // ccTextBoxPassword
            // 
            ccTextBoxPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxPassword.IsRequired = false;
            ccTextBoxPassword.Location = new Point(573, 217);
            ccTextBoxPassword.Name = "ccTextBoxPassword";
            ccTextBoxPassword.Size = new Size(261, 27);
            ccTextBoxPassword.TabIndex = 1;
            ccTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(527, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(527, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // chbRememberMe
            // 
            chbRememberMe.AutoSize = true;
            chbRememberMe.Location = new Point(573, 272);
            chbRememberMe.Name = "chbRememberMe";
            chbRememberMe.Size = new Size(133, 24);
            chbRememberMe.TabIndex = 2;
            chbRememberMe.Text = "Remember Me ";
            chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(126, 87, 194);
            btnLogin.Font = new Font("Segoe UI", 9F);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Image = Properties.Resources.Next_32;
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(707, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources.billiard_ball;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(412, 484);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Vivaldi", 22F, FontStyle.Italic);
            label4.Location = new Point(53, 431);
            label4.Name = "label4";
            label4.Size = new Size(277, 44);
            label4.TabIndex = 42;
            label4.Text = "Moaz 8 Pool Club";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            CancelButton = btnClose;
            ClientSize = new Size(846, 484);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(chbRememberMe);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ccTextBoxPassword);
            Controls.Add(ccTextBoxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private People.CustomControl.ccTextBox ccTextBoxUserName;
        private People.CustomControl.ccTextBox ccTextBoxPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox chbRememberMe;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private Label label4;
    }
}