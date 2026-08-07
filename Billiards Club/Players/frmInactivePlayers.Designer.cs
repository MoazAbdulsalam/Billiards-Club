namespace Billiards_Club.Players
{
    partial class frmInactivePlayers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInactivePlayers));
            lblRecordCount = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            dgvListPlayers = new DataGridView();
            cmPlayer = new ContextMenuStrip(components);
            RestorePlayerToolStripMenuItem = new ToolStripMenuItem();
            ccTextBoxSearch = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox1 = new PictureBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListPlayers).BeginInit();
            cmPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9F);
            lblRecordCount.Location = new Point(1208, 623);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(30, 20);
            lblRecordCount.TabIndex = 46;
            lblRecordCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(1127, 623);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 45;
            label3.Text = "# Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(448, 54);
            label2.TabIndex = 44;
            label2.Text = "Manage Inactive Players";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(32, 568);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(298, 49);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvListPlayers
            // 
            dgvListPlayers.AllowUserToAddRows = false;
            dgvListPlayers.AllowUserToDeleteRows = false;
            dgvListPlayers.AllowUserToOrderColumns = true;
            dgvListPlayers.BackgroundColor = Color.FromArgb(242, 232, 242);
            dgvListPlayers.BorderStyle = BorderStyle.Fixed3D;
            dgvListPlayers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListPlayers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPlayers.ContextMenuStrip = cmPlayer;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListPlayers.EnableHeadersVisualStyles = false;
            dgvListPlayers.GridColor = Color.DarkViolet;
            dgvListPlayers.Location = new Point(332, 65);
            dgvListPlayers.Name = "dgvListPlayers";
            dgvListPlayers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 232, 242);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListPlayers.RowHeadersVisible = false;
            dgvListPlayers.RowHeadersWidth = 51;
            dgvListPlayers.Size = new Size(910, 552);
            dgvListPlayers.TabIndex = 38;
            dgvListPlayers.CellDoubleClick += RestorePlayerToolStripMenuItem_Click;
            // 
            // cmPlayer
            // 
            cmPlayer.ImageScalingSize = new Size(20, 20);
            cmPlayer.Items.AddRange(new ToolStripItem[] { RestorePlayerToolStripMenuItem });
            cmPlayer.Name = "cmPerson";
            cmPlayer.Size = new Size(215, 58);
            cmPlayer.Opening += cmPlayer_Opening;
            // 
            // RestorePlayerToolStripMenuItem
            // 
            RestorePlayerToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            RestorePlayerToolStripMenuItem.Name = "RestorePlayerToolStripMenuItem";
            RestorePlayerToolStripMenuItem.Size = new Size(214, 26);
            RestorePlayerToolStripMenuItem.Text = "Restore Player ";
            RestorePlayerToolStripMenuItem.Click += RestorePlayerToolStripMenuItem_Click;
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(41, 339);
            ccTextBoxSearch.Name = "ccTextBoxSearch";
            ccTextBoxSearch.Size = new Size(280, 27);
            ccTextBoxSearch.TabIndex = 41;
            ccTextBoxSearch.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Lavender;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Player ID", "Person ID", "Full Name" });
            cbFilter.Location = new Point(138, 281);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(183, 28);
            cbFilter.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 284);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 39;
            label1.Text = "FilterBy  :";
            // 
            // frmInactivePlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1259, 674);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dgvListPlayers);
            Controls.Add(ccTextBoxSearch);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmInactivePlayers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inactive Players";
            Load += frmInactivePlayers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPlayers).EndInit();
            cmPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordCount;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private DataGridView dgvListPlayers;
        private People.CustomControl.ccTextBox ccTextBoxSearch;
        private PictureBox pictureBox1;
        private ComboBox cbFilter;
        private Label label1;
        private ContextMenuStrip cmPlayer;
        private ToolStripMenuItem RestorePlayerToolStripMenuItem;
    }
}