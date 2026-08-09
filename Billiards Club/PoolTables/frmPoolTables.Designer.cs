namespace Billiards_Club.PoolTables
{
    partial class frmPoolTables
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            lblAvailableTable = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1349, 555);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Available Tables :";
            // 
            // lblAvailableTable
            // 
            lblAvailableTable.AutoSize = true;
            lblAvailableTable.Location = new Point(132, 9);
            lblAvailableTable.Name = "lblAvailableTable";
            lblAvailableTable.Size = new Size(37, 20);
            lblAvailableTable.TabIndex = 1;
            lblAvailableTable.Text = "????";
            // 
            // frmPoolTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1349, 598);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblAvailableTable);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmPoolTables";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pool Tables";
            Load += frmPoolTables_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblAvailableTable;
    }
}