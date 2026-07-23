namespace Billiards_Club.People
{
    partial class frmAddEditPerson
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
            lblHeader = new Label();
            pictureBox2 = new PictureBox();
            lblPersonID = new Label();
            label2 = new Label();
            gbData = new GroupBox();
            llRemove = new LinkLabel();
            llSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            ccTextBoxPhone = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox8 = new PictureBox();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox7 = new PictureBox();
            label11 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            ccTextBoxAddress = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            ccTextBoxEmail = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            rbFemale = new RadioButton();
            pictureBox4 = new PictureBox();
            rbMale = new RadioButton();
            pbGenderImage = new PictureBox();
            label8 = new Label();
            ccTextBoxNationalNo = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            ccTextBoxLastName = new Billiards_Club.People.CustomControl.ccTextBox();
            ccTextBoxThirdName = new Billiards_Club.People.CustomControl.ccTextBox();
            ccTextBoxSecondName = new Billiards_Club.People.CustomControl.ccTextBox();
            ccTextBoxFirstName = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGenderImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(402, 29);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(296, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "ADD/Edit Person";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_32;
            pictureBox2.Location = new Point(127, 77);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Location = new Point(187, 73);
            lblPersonID.Margin = new Padding(4, 0, 4, 0);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(51, 28);
            lblPersonID.TabIndex = 7;
            lblPersonID.Text = "[???]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 6;
            label2.Text = "PersonID :";
            // 
            // gbData
            // 
            gbData.BackColor = Color.FromArgb(242, 232, 242);
            gbData.Controls.Add(llRemove);
            gbData.Controls.Add(llSetImage);
            gbData.Controls.Add(pbPersonImage);
            gbData.Controls.Add(ccTextBoxPhone);
            gbData.Controls.Add(pictureBox8);
            gbData.Controls.Add(label12);
            gbData.Controls.Add(dateTimePicker1);
            gbData.Controls.Add(pictureBox7);
            gbData.Controls.Add(label11);
            gbData.Controls.Add(btnSave);
            gbData.Controls.Add(btnClose);
            gbData.Controls.Add(ccTextBoxAddress);
            gbData.Controls.Add(pictureBox6);
            gbData.Controls.Add(label10);
            gbData.Controls.Add(ccTextBoxEmail);
            gbData.Controls.Add(pictureBox5);
            gbData.Controls.Add(label9);
            gbData.Controls.Add(rbFemale);
            gbData.Controls.Add(pictureBox4);
            gbData.Controls.Add(rbMale);
            gbData.Controls.Add(pbGenderImage);
            gbData.Controls.Add(label8);
            gbData.Controls.Add(ccTextBoxNationalNo);
            gbData.Controls.Add(pictureBox3);
            gbData.Controls.Add(label7);
            gbData.Controls.Add(label6);
            gbData.Controls.Add(label5);
            gbData.Controls.Add(label4);
            gbData.Controls.Add(label1);
            gbData.Controls.Add(ccTextBoxLastName);
            gbData.Controls.Add(ccTextBoxThirdName);
            gbData.Controls.Add(ccTextBoxSecondName);
            gbData.Controls.Add(ccTextBoxFirstName);
            gbData.Controls.Add(pictureBox1);
            gbData.Controls.Add(label3);
            gbData.Location = new Point(12, 112);
            gbData.Name = "gbData";
            gbData.Size = new Size(1049, 408);
            gbData.TabIndex = 9;
            gbData.TabStop = false;
            // 
            // llRemove
            // 
            llRemove.AutoSize = true;
            llRemove.Location = new Point(951, 332);
            llRemove.Name = "llRemove";
            llRemove.Size = new Size(82, 28);
            llRemove.TabIndex = 44;
            llRemove.TabStop = true;
            llRemove.Text = "Remove";
            llRemove.LinkClicked += llRemove_LinkClicked;
            // 
            // llSetImage
            // 
            llSetImage.AutoSize = true;
            llSetImage.Location = new Point(850, 332);
            llSetImage.Name = "llSetImage";
            llSetImage.Size = new Size(99, 28);
            llSetImage.TabIndex = 43;
            llSetImage.TabStop = true;
            llSetImage.Text = "Set Image";
            llSetImage.LinkClicked += llSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = Properties.Resources.Male_512;
            pbPersonImage.Location = new Point(849, 112);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(184, 208);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 42;
            pbPersonImage.TabStop = false;
            // 
            // ccTextBoxPhone
            // 
            ccTextBoxPhone.InputType = CustomControl.ccTextBox.InputTypeEnum.NumberInput;
            ccTextBoxPhone.IsRequired = false;
            ccTextBoxPhone.Location = new Point(644, 160);
            ccTextBoxPhone.MaxLength = 11;
            ccTextBoxPhone.Name = "ccTextBoxPhone";
            ccTextBoxPhone.Size = new Size(184, 34);
            ccTextBoxPhone.TabIndex = 41;
            ccTextBoxPhone.Validating += _Valedite;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Email_32;
            pictureBox8.Location = new Point(571, 164);
            pictureBox8.Margin = new Padding(4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(52, 28);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 40;
            pictureBox8.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(487, 163);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(76, 28);
            label12.TabIndex = 39;
            label12.Text = "Phone :";
            label12.Click += label12_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Location = new Point(644, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(184, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Calendar_32;
            pictureBox7.Location = new Point(571, 108);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 37;
            pictureBox7.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(438, 104);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(129, 28);
            label11.TabIndex = 36;
            label11.Text = "Date Of Birth:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(126, 87, 194);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Image = Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(666, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 45);
            btnSave.TabIndex = 35;
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
            btnClose.Location = new Point(475, 344);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(162, 45);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ccTextBoxAddress
            // 
            ccTextBoxAddress.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxAddress.IsRequired = false;
            ccTextBoxAddress.Location = new Point(229, 264);
            ccTextBoxAddress.Multiline = true;
            ccTextBoxAddress.Name = "ccTextBoxAddress";
            ccTextBoxAddress.Size = new Size(599, 74);
            ccTextBoxAddress.TabIndex = 34;
            ccTextBoxAddress.Validating += _Valedite;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Address_321;
            pictureBox6.Location = new Point(155, 264);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 260);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 28);
            label10.TabIndex = 32;
            label10.Text = " Address :";
            // 
            // ccTextBoxEmail
            // 
            ccTextBoxEmail.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxEmail.IsRequired = false;
            ccTextBoxEmail.Location = new Point(229, 210);
            ccTextBoxEmail.Name = "ccTextBoxEmail";
            ccTextBoxEmail.Size = new Size(184, 34);
            ccTextBoxEmail.TabIndex = 31;
            ccTextBoxEmail.Validating += ccTextBoxEmail_Validating;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Email_32;
            pictureBox5.Location = new Point(155, 210);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 206);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 29;
            label9.Text = "Email :";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10F);
            rbFemale.Location = new Point(341, 165);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(85, 27);
            rbFemale.TabIndex = 28;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Woman_32;
            pictureBox4.Location = new Point(295, 160);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 10F);
            rbMale.Location = new Point(229, 165);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(68, 27);
            rbMale.TabIndex = 26;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // pbGenderImage
            // 
            pbGenderImage.Image = Properties.Resources.Man_32;
            pbGenderImage.Location = new Point(155, 160);
            pbGenderImage.Name = "pbGenderImage";
            pbGenderImage.Size = new Size(52, 32);
            pbGenderImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGenderImage.TabIndex = 25;
            pbGenderImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 160);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 23;
            label8.Text = "Gender :";
            // 
            // ccTextBoxNationalNo
            // 
            ccTextBoxNationalNo.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxNationalNo.IsRequired = true;
            ccTextBoxNationalNo.Location = new Point(229, 108);
            ccTextBoxNationalNo.Name = "ccTextBoxNationalNo";
            ccTextBoxNationalNo.Size = new Size(184, 34);
            ccTextBoxNationalNo.TabIndex = 22;
            ccTextBoxNationalNo.Validating += _Valedite;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Number_32;
            pictureBox3.Location = new Point(155, 108);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 104);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 20;
            label7.Text = "National No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(904, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 28);
            label6.TabIndex = 19;
            label6.Text = "Last";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(698, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 28);
            label5.TabIndex = 18;
            label5.Text = "Third";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 17;
            label4.Text = "Second";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 16;
            label1.Text = "First";
            // 
            // ccTextBoxLastName
            // 
            ccTextBoxLastName.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxLastName.IsRequired = true;
            ccTextBoxLastName.Location = new Point(849, 61);
            ccTextBoxLastName.Name = "ccTextBoxLastName";
            ccTextBoxLastName.Size = new Size(184, 34);
            ccTextBoxLastName.TabIndex = 15;
            ccTextBoxLastName.Validating += _Valedite;
            // 
            // ccTextBoxThirdName
            // 
            ccTextBoxThirdName.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxThirdName.IsRequired = false;
            ccTextBoxThirdName.Location = new Point(644, 61);
            ccTextBoxThirdName.Name = "ccTextBoxThirdName";
            ccTextBoxThirdName.Size = new Size(184, 34);
            ccTextBoxThirdName.TabIndex = 14;
            ccTextBoxThirdName.Validating += _Valedite;
            // 
            // ccTextBoxSecondName
            // 
            ccTextBoxSecondName.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSecondName.IsRequired = true;
            ccTextBoxSecondName.Location = new Point(438, 61);
            ccTextBoxSecondName.Name = "ccTextBoxSecondName";
            ccTextBoxSecondName.Size = new Size(184, 34);
            ccTextBoxSecondName.TabIndex = 13;
            ccTextBoxSecondName.Validating += _Valedite;
            // 
            // ccTextBoxFirstName
            // 
            ccTextBoxFirstName.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxFirstName.IsRequired = true;
            ccTextBoxFirstName.Location = new Point(229, 61);
            ccTextBoxFirstName.Name = "ccTextBoxFirstName";
            ccTextBoxFirstName.Size = new Size(184, 34);
            ccTextBoxFirstName.TabIndex = 12;
            ccTextBoxFirstName.Validating += _Valedite;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Person_32;
            pictureBox1.Location = new Point(155, 61);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 9;
            label3.Text = "Name :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditPerson
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1066, 537);
            Controls.Add(gbData);
            Controls.Add(pictureBox2);
            Controls.Add(lblPersonID);
            Controls.Add(label2);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmAddEditPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditPerson";
            Load += frmAddEditPerson_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbData.ResumeLayout(false);
            gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGenderImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox pictureBox2;
        private Label lblPersonID;
        private Label label2;
        private GroupBox gbData;
        private CustomControl.ccTextBox ccTextBoxFirstName;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnClose;
        private CustomControl.ccTextBox ccTextBoxLastName;
        private CustomControl.ccTextBox ccTextBoxThirdName;
        private CustomControl.ccTextBox ccTextBoxSecondName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private CustomControl.ccTextBox ccTextBoxNationalNo;
        private PictureBox pictureBox3;
        private Label label7;
        private CustomControl.ccTextBox ccTextBoxAddress;
        private PictureBox pictureBox6;
        private Label label10;
        private CustomControl.ccTextBox ccTextBoxEmail;
        private PictureBox pictureBox5;
        private Label label9;
        private RadioButton rbFemale;
        private PictureBox pictureBox4;
        private RadioButton rbMale;
        private PictureBox pbGenderImage;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label11;
        private Button btnSave;
        private CustomControl.ccTextBox ccTextBoxPhone;
        private PictureBox pictureBox8;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private LinkLabel llRemove;
        private LinkLabel llSetImage;
        private PictureBox pbPersonImage;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}