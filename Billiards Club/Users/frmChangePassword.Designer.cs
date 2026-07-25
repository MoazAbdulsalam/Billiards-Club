namespace Billiards_Club.Users
{
    partial class frmChangePassword
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
            components = new System.ComponentModel.Container();
            ctrlUserInfo1 = new Billiards_Club.Users.Controls.ctrlUserInfo();
            ccTextBoxConfirmPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            label4 = new Label();
            ccTextBoxNewPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            label2 = new Label();
            ccTextBoxOldPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            label3 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlUserInfo1.Location = new Point(0, 132);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(832, 566);
            ctrlUserInfo1.TabIndex = 0;
            // 
            // ccTextBoxConfirmPassword
            // 
            ccTextBoxConfirmPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxConfirmPassword.IsRequired = true;
            ccTextBoxConfirmPassword.Location = new Point(1049, 294);
            ccTextBoxConfirmPassword.MaxLength = 8;
            ccTextBoxConfirmPassword.Name = "ccTextBoxConfirmPassword";
            ccTextBoxConfirmPassword.Size = new Size(257, 27);
            ccTextBoxConfirmPassword.TabIndex = 21;
            ccTextBoxConfirmPassword.UseSystemPasswordChar = true;
            ccTextBoxConfirmPassword.Validating += ccTextBoxConfirmPassword_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(856, 294);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 20;
            label4.Text = "Confirm Password :";
            // 
            // ccTextBoxNewPassword
            // 
            ccTextBoxNewPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxNewPassword.IsRequired = true;
            ccTextBoxNewPassword.Location = new Point(1049, 253);
            ccTextBoxNewPassword.MaxLength = 8;
            ccTextBoxNewPassword.Name = "ccTextBoxNewPassword";
            ccTextBoxNewPassword.Size = new Size(257, 27);
            ccTextBoxNewPassword.TabIndex = 19;
            ccTextBoxNewPassword.UseSystemPasswordChar = true;
            ccTextBoxNewPassword.Validating += ccTextBoxNewPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(886, 253);
            label2.Name = "label2";
            label2.Size = new Size(146, 28);
            label2.TabIndex = 18;
            label2.Text = "New Password :";
            // 
            // ccTextBoxOldPassword
            // 
            ccTextBoxOldPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxOldPassword.IsRequired = true;
            ccTextBoxOldPassword.Location = new Point(1049, 208);
            ccTextBoxOldPassword.MaxLength = 8;
            ccTextBoxOldPassword.Name = "ccTextBoxOldPassword";
            ccTextBoxOldPassword.Size = new Size(257, 27);
            ccTextBoxOldPassword.TabIndex = 23;
            ccTextBoxOldPassword.UseSystemPasswordChar = true;
            ccTextBoxOldPassword.Validating += ccTextBoxOldPassword_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(930, 208);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 22;
            label3.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(520, 39);
            label1.Name = "label1";
            label1.Size = new Size(312, 50);
            label1.TabIndex = 24;
            label1.Text = "Change Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 87, 194);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(1144, 626);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 45);
            btnSave.TabIndex = 39;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(953, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 45);
            btnClose.TabIndex = 38;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1345, 699);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(ccTextBoxOldPassword);
            Controls.Add(label3);
            Controls.Add(ccTextBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(ccTextBoxNewPassword);
            Controls.Add(label2);
            Controls.Add(ctrlUserInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlUserInfo ctrlUserInfo1;
        private People.CustomControl.ccTextBox ccTextBoxConfirmPassword;
        private Label label4;
        private People.CustomControl.ccTextBox ccTextBoxNewPassword;
        private Label label2;
        private People.CustomControl.ccTextBox ccTextBoxOldPassword;
        private Label label3;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}