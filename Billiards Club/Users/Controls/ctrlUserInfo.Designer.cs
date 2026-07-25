namespace Billiards_Club.Users.Controls
{
    partial class ctrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new Billiards_Club.People.UserControls.ctrlPersonCard();
            gbUserInfo = new GroupBox();
            pictureBox3 = new PictureBox();
            lblIsActive = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            lblUserName = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            lblUserID = new Label();
            label1 = new Label();
            gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPersonCard1.Location = new Point(3, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(813, 431);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(pictureBox3);
            gbUserInfo.Controls.Add(lblIsActive);
            gbUserInfo.Controls.Add(label5);
            gbUserInfo.Controls.Add(pictureBox1);
            gbUserInfo.Controls.Add(lblUserName);
            gbUserInfo.Controls.Add(label3);
            gbUserInfo.Controls.Add(pictureBox2);
            gbUserInfo.Controls.Add(lblUserID);
            gbUserInfo.Controls.Add(label1);
            gbUserInfo.Location = new Point(3, 440);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(813, 115);
            gbUserInfo.TabIndex = 1;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "User Information :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(648, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(692, 52);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(40, 20);
            lblIsActive.TabIndex = 13;
            lblIsActive.Text = "[???]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 52);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 12;
            label5.Text = "Is Active:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User_32__2;
            pictureBox1.Location = new Point(387, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(431, 52);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(40, 20);
            lblUserName.TabIndex = 10;
            lblUserName.Text = "[???]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 52);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 9;
            label3.Text = "UserName :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(103, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(147, 52);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(40, 20);
            lblUserID.TabIndex = 7;
            lblUserID.Text = "[???]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 6;
            label1.Text = "UserID :";
            // 
            // ctrlUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 242);
            Controls.Add(gbUserInfo);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserInfo";
            Size = new Size(825, 561);
            gbUserInfo.ResumeLayout(false);
            gbUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private People.UserControls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbUserInfo;
        private PictureBox pictureBox3;
        private Label lblIsActive;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblUserName;
        private Label label3;
        private PictureBox pictureBox2;
        private Label lblUserID;
        private Label label1;
    }
}
