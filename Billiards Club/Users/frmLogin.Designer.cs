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
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SlateBlue;
            btnClose.Image = Properties.Resources.closeBlack32;
            btnClose.Location = new Point(791, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 43);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(440, 83);
            label1.Name = "label1";
            label1.Size = new Size(123, 50);
            label1.TabIndex = 1;
            label1.Text = "Login ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(445, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "UserName";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(846, 484);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
    }
}