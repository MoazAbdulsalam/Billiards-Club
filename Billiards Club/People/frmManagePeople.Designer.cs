namespace Billiards_Club.People
{
    partial class frmManagePeople
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
            pictureBox1 = new PictureBox();
            dgvListPeople = new DataGridView();
            cmPerson = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            btnAddNewPerson = new Button();
            ccTextBoxSearch = new Billiards_Club.People.CustomControl.ccTextBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            btnClose = new Button();
            label2 = new Label();
            label3 = new Label();
            lblRecordCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).BeginInit();
            cmPerson.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Manage_People;
            pictureBox1.Location = new Point(12, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvListPeople
            // 
            dgvListPeople.AllowUserToAddRows = false;
            dgvListPeople.AllowUserToDeleteRows = false;
            dgvListPeople.AllowUserToOrderColumns = true;
            dgvListPeople.BackgroundColor = Color.FromArgb(242, 232, 242);
            dgvListPeople.BorderStyle = BorderStyle.Fixed3D;
            dgvListPeople.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListPeople.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListPeople.ContextMenuStrip = cmPerson;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListPeople.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListPeople.EnableHeadersVisualStyles = false;
            dgvListPeople.GridColor = Color.DarkViolet;
            dgvListPeople.Location = new Point(312, 66);
            dgvListPeople.Name = "dgvListPeople";
            dgvListPeople.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(242, 232, 242);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListPeople.RowHeadersVisible = false;
            dgvListPeople.RowHeadersWidth = 51;
            dgvListPeople.Size = new Size(1054, 552);
            dgvListPeople.TabIndex = 1;
            dgvListPeople.CellContentDoubleClick += dgvListPeople_CellContentDoubleClick;
            // 
            // cmPerson
            // 
            cmPerson.ImageScalingSize = new Size(20, 20);
            cmPerson.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmPerson.Name = "cmPerson";
            cmPerson.Size = new Size(169, 146);
            cmPerson.Opening += cmPerson_Opening;
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
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_32;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(168, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
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
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewPerson.Image = Properties.Resources.Add_Person_40;
            btnAddNewPerson.Location = new Point(21, 533);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(137, 85);
            btnAddNewPerson.TabIndex = 5;
            btnAddNewPerson.UseVisualStyleBackColor = false;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(21, 340);
            ccTextBoxSearch.Name = "ccTextBoxSearch";
            ccTextBoxSearch.Size = new Size(280, 34);
            ccTextBoxSearch.TabIndex = 3;
            ccTextBoxSearch.TextChanged += ccTextBoxSearch_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Lavender;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Gender", "Phone", "Email" });
            cbFilter.Location = new Point(118, 282);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(183, 36);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 285);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 1;
            label1.Text = "FilterBy  :";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(175, 533);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 85);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(298, 54);
            label2.TabIndex = 12;
            label2.Text = "Manage People";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(1227, 622);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 14;
            label3.Text = "# Records";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9F);
            lblRecordCount.Location = new Point(1308, 622);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(30, 20);
            lblRecordCount.TabIndex = 15;
            lblRecordCount.Text = "???";
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1371, 651);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewPerson);
            Controls.Add(dgvListPeople);
            Controls.Add(ccTextBoxSearch);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmManagePeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage People";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListPeople).EndInit();
            cmPerson.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvListPeople;
        private Button btnAddNewPerson;
        private CustomControl.ccTextBox ccTextBoxSearch;
        private ComboBox cbFilter;
        private Label label1;
        private Button btnClose;
        private Label label2;
        private ContextMenuStrip cmPerson;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private Label label3;
        private Label lblRecordCount;
    }
}