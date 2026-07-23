namespace Billiards_Club.People
{
    partial class frmPersonDetails
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
            ctrlPersonCard1 = new Billiards_Club.People.UserControls.ctrlPersonCard();
            btnClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Lavender;
            ctrlPersonCard1.Location = new Point(5, 47);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(793, 413);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(601, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(197, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 2;
            label1.Text = "Person Details";
            // 
            // frmPersonDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            CancelButton = btnClose;
            ClientSize = new Size(809, 520);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPersonDetails";
            Text = "Person Details";
            Load += frmPersonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.ctrlPersonCard ctrlPersonCard1;
        private Button btnClose;
        private Label label1;
    }
}