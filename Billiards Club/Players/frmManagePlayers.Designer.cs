namespace Billiards_Club.Players
{
    partial class frmManagePlayers
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
            lblRecordCount = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnAddNewPlayer = new Button();
            dgvListPlayers = new DataGridView();
            cmPlayer = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
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
            lblRecordCount.Location = new Point(1202, 626);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(30, 20);
            lblRecordCount.TabIndex = 36;
            lblRecordCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(1121, 626);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 35;
            label3.Text = "# Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(26, 15);
            label2.Name = "label2";
            label2.Size = new Size(301, 54);
            label2.TabIndex = 34;
            label2.Text = "Manage Players";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(189, 512);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 108);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewPlayer
            // 
            btnAddNewPlayer.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewPlayer.BackgroundImage = Properties.Resources.soccer_player;
            btnAddNewPlayer.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddNewPlayer.Location = new Point(26, 512);
            btnAddNewPlayer.Name = "btnAddNewPlayer";
            btnAddNewPlayer.Size = new Size(146, 108);
            btnAddNewPlayer.TabIndex = 32;
            btnAddNewPlayer.UseVisualStyleBackColor = false;
            btnAddNewPlayer.Click += btnAddNewPlayer_Click;
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
            dgvListPlayers.Location = new Point(326, 68);
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
            dgvListPlayers.TabIndex = 28;
            // 
            // cmPlayer
            // 
            cmPlayer.ImageScalingSize = new Size(20, 20);
            cmPlayer.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, deleteToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmPlayer.Name = "cmPerson";
            cmPlayer.Size = new Size(169, 120);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(168, 26);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(165, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(168, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(165, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Image = Properties.Resources.Email_32;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(168, 26);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_321;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(168, 26);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(35, 342);
            ccTextBoxSearch.Name = "ccTextBoxSearch";
            ccTextBoxSearch.Size = new Size(280, 27);
            ccTextBoxSearch.TabIndex = 31;
            ccTextBoxSearch.Visible = false;
            ccTextBoxSearch.TextChanged += ccTextBoxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.team;
            pictureBox1.Location = new Point(26, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Lavender;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Player ID", "Person ID", "Full Name" });
            cbFilter.Location = new Point(132, 284);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(183, 28);
            cbFilter.TabIndex = 30;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 287);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 29;
            label1.Text = "FilterBy  :";
            // 
            // frmManagePlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1262, 661);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewPlayer);
            Controls.Add(dgvListPlayers);
            Controls.Add(ccTextBoxSearch);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManagePlayers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Players";
            Load += frmManagePlayers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListPlayers).EndInit();
            cmPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbIsActive;
        private Label lblRecordCount;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Button btnAddNewPlayer;
        private DataGridView dgvListPlayers;
        private People.CustomControl.ccTextBox ccTextBoxSearch;
        private PictureBox pictureBox1;
        private ComboBox cbFilter;
        private Label label1;
        private ContextMenuStrip cmPlayer;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}