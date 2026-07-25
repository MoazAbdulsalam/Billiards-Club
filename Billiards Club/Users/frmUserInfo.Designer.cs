namespace Billiards_Club.Users
{
    partial class frmUserInfo
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
            ctrlUserInfo1 = new Billiards_Club.Users.Controls.ctrlUserInfo();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            ctrlUserInfo1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlUserInfo1.Location = new Point(12, 12);
            ctrlUserInfo1.Name = "ctrlUserInfo1";
            ctrlUserInfo1.Size = new Size(832, 566);
            ctrlUserInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(689, 584);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(155, 39);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(858, 629);
            Controls.Add(btnClose);
            Controls.Add(ctrlUserInfo1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Info";
            Load += frmUserInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlUserInfo ctrlUserInfo1;
        private Button btnClose;
    }
}