namespace Billiards_Club.Players
{
    partial class frmPlayerDetails
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ctrlPlayerCard1 = new Billiards_Club.Players.Controls.ctrlPlayerCard();
            label1 = new Label();
            dgvListPlayerPayments = new DataGridView();
            btnClose = new Button();
            lblRecordCount = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListPlayerPayments).BeginInit();
            SuspendLayout();
            // 
            // ctrlPlayerCard1
            // 
            ctrlPlayerCard1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPlayerCard1.Location = new Point(12, 53);
            ctrlPlayerCard1.Name = "ctrlPlayerCard1";
            ctrlPlayerCard1.Size = new Size(1116, 435);
            ctrlPlayerCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(431, 3);
            label1.Name = "label1";
            label1.Size = new Size(242, 50);
            label1.TabIndex = 1;
            label1.Text = "Player Details";
            // 
            // dgvListPlayerPayments
            // 
            dgvListPlayerPayments.AllowUserToAddRows = false;
            dgvListPlayerPayments.AllowUserToDeleteRows = false;
            dgvListPlayerPayments.AllowUserToOrderColumns = true;
            dgvListPlayerPayments.BackgroundColor = Color.FromArgb(242, 232, 242);
            dgvListPlayerPayments.BorderStyle = BorderStyle.Fixed3D;
            dgvListPlayerPayments.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListPlayerPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListPlayerPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListPlayerPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListPlayerPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListPlayerPayments.EnableHeadersVisualStyles = false;
            dgvListPlayerPayments.GridColor = Color.DarkViolet;
            dgvListPlayerPayments.Location = new Point(12, 510);
            dgvListPlayerPayments.Name = "dgvListPlayerPayments";
            dgvListPlayerPayments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 232, 242);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListPlayerPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListPlayerPayments.RowHeadersVisible = false;
            dgvListPlayerPayments.RowHeadersWidth = 51;
            dgvListPlayerPayments.Size = new Size(954, 176);
            dgvListPlayerPayments.TabIndex = 18;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(975, 595);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(156, 91);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9F);
            lblRecordCount.Location = new Point(1066, 510);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(30, 20);
            lblRecordCount.TabIndex = 27;
            lblRecordCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(985, 510);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 26;
            label3.Text = "# Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 485);
            label2.Name = "label2";
            label2.Size = new Size(234, 25);
            label2.TabIndex = 28;
            label2.Text = "P l a y e r  P a y m e n t s   :";
            // 
            // frmPlayerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1140, 699);
            Controls.Add(label2);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(dgvListPlayerPayments);
            Controls.Add(label1);
            Controls.Add(ctrlPlayerCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPlayerDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Details";
            Load += frmPlayerDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPlayerPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPlayerCard ctrlPlayerCard1;
        private Label label1;
        private DataGridView dgvListPlayerPayments;
        private Button btnClose;
        private Label lblRecordCount;
        private Label label3;
        private Label label2;
    }
}