namespace Billiards_Club.Users
{
    partial class frmAddEditUser
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
            tabControl1 = new TabControl();
            tpPersonInfo = new TabPage();
            btnNext = new Button();
            ctrlPersonCardWithFilter1 = new Billiards_Club.People.UserControls.ctrlPersonCardWithFilter();
            tpLoginInfo = new TabPage();
            panelPassword = new Panel();
            ccTextBoxPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            lblPassword = new Label();
            ccTextBoxConfirmPassword = new Billiards_Club.People.CustomControl.ccTextBox();
            lblconferm = new Label();
            chbIsActive = new CheckBox();
            ccTextBoxUserName = new Billiards_Club.People.CustomControl.ccTextBox();
            label3 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            lblHeader = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonInfo);
            tabControl1.Controls.Add(tpLoginInfo);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(841, 604);
            tabControl1.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.BackColor = Color.FromArgb(242, 232, 242);
            tpPersonInfo.Controls.Add(btnNext);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 29);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(833, 571);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(126, 87, 194);
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Image = Properties.Resources.Next_32;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(700, 522);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(127, 43);
            btnNext.TabIndex = 39;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(6, 6);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(804, 510);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.BackColor = Color.FromArgb(242, 232, 242);
            tpLoginInfo.Controls.Add(panelPassword);
            tpLoginInfo.Controls.Add(chbIsActive);
            tpLoginInfo.Controls.Add(ccTextBoxUserName);
            tpLoginInfo.Controls.Add(label3);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Font = new Font("Segoe UI", 12F);
            tpLoginInfo.Location = new Point(4, 29);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(833, 571);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "Login Info";
            // 
            // panelPassword
            // 
            panelPassword.Controls.Add(ccTextBoxPassword);
            panelPassword.Controls.Add(lblPassword);
            panelPassword.Controls.Add(ccTextBoxConfirmPassword);
            panelPassword.Controls.Add(lblconferm);
            panelPassword.Location = new Point(36, 184);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(476, 135);
            panelPassword.TabIndex = 19;
            // 
            // ccTextBoxPassword
            // 
            ccTextBoxPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxPassword.IsRequired = true;
            ccTextBoxPassword.Location = new Point(197, 21);
            ccTextBoxPassword.MaxLength = 8;
            ccTextBoxPassword.Name = "ccTextBoxPassword";
            ccTextBoxPassword.Size = new Size(257, 34);
            ccTextBoxPassword.TabIndex = 15;
            ccTextBoxPassword.UseSystemPasswordChar = true;
            ccTextBoxPassword.Validating += ccTextBoxPassword_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(79, 21);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 28);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password :";
            // 
            // ccTextBoxConfirmPassword
            // 
            ccTextBoxConfirmPassword.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxConfirmPassword.IsRequired = true;
            ccTextBoxConfirmPassword.Location = new Point(197, 87);
            ccTextBoxConfirmPassword.MaxLength = 8;
            ccTextBoxConfirmPassword.Name = "ccTextBoxConfirmPassword";
            ccTextBoxConfirmPassword.Size = new Size(257, 34);
            ccTextBoxConfirmPassword.TabIndex = 17;
            ccTextBoxConfirmPassword.UseSystemPasswordChar = true;
            ccTextBoxConfirmPassword.Validating += ccTextBoxConfirmPassword_Validating;
            // 
            // lblconferm
            // 
            lblconferm.AutoSize = true;
            lblconferm.Location = new Point(4, 87);
            lblconferm.Name = "lblconferm";
            lblconferm.Size = new Size(177, 28);
            lblconferm.TabIndex = 16;
            lblconferm.Text = "Confirm Password :";
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.Location = new Point(214, 315);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(106, 32);
            chbIsActive.TabIndex = 18;
            chbIsActive.Text = "Is Active";
            chbIsActive.UseVisualStyleBackColor = true;
            // 
            // ccTextBoxUserName
            // 
            ccTextBoxUserName.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxUserName.IsRequired = true;
            ccTextBoxUserName.Location = new Point(235, 131);
            ccTextBoxUserName.Name = "ccTextBoxUserName";
            ccTextBoxUserName.Size = new Size(257, 34);
            ccTextBoxUserName.TabIndex = 13;
            ccTextBoxUserName.Validating += ccTextBoxUserName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 131);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 12;
            label3.Text = "UserName :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(224, 56);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(51, 28);
            lblUserID.TabIndex = 10;
            lblUserID.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 9;
            label1.Text = "UserID :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 87, 194);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(682, 674);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 45);
            btnSave.TabIndex = 37;
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
            btnClose.Location = new Point(491, 674);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 45);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(271, 23);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(257, 50);
            lblHeader.TabIndex = 38;
            lblHeader.Text = "Add New User";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(855, 753);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Edit User";
            Load += frmAddEditUser_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpPersonInfo;
        private People.UserControls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Button btnSave;
        private Button btnClose;
        private Label lblHeader;
        private Button btnNext;
        private ErrorProvider errorProvider1;
        private TabPage tpLoginInfo;
        private CheckBox chbIsActive;
        private People.CustomControl.ccTextBox ccTextBoxConfirmPassword;
        private Label lblconferm;
        private People.CustomControl.ccTextBox ccTextBoxPassword;
        private Label lblPassword;
        private People.CustomControl.ccTextBox ccTextBoxUserName;
        private Label label3;
        private Label lblUserID;
        private Label label1;
        private Panel panelPassword;
    }
}