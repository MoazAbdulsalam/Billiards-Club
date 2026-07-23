namespace Billiards_Club.People
{
    partial class frmFindPerson
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
            ctrlPersonCardWithFilter1 = new Billiards_Club.People.UserControls.ctrlPersonCardWithFilter();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(591, 580);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(197, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(4, 63);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(784, 511);
            ctrlPersonCardWithFilter1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 50);
            label1.TabIndex = 4;
            label1.Text = "Find Person";
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            CancelButton = btnClose;
            ClientSize = new Size(799, 627);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmFindPerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private UserControls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label label1;
    }
}