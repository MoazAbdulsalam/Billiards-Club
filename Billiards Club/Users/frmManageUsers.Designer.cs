namespace Billiards_Club
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblRecordCount = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnAddNewUser = new Button();
            dgvListUsers = new DataGridView();
            cmUser = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripSeparator();
            addNewUserToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            ccTextBoxSearch = new Billiards_Club.People.CustomControl.ccTextBox();
            pictureBox1 = new PictureBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            cbIsActive = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListUsers).BeginInit();
            cmUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 9F);
            lblRecordCount.Location = new Point(1183, 621);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(30, 20);
            lblRecordCount.TabIndex = 25;
            lblRecordCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(1102, 621);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 24;
            label3.Text = "# Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(7, 10);
            label2.Name = "label2";
            label2.Size = new Size(274, 54);
            label2.TabIndex = 23;
            label2.Text = "Manage Users";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(170, 530);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 85);
            btnClose.TabIndex = 22;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewUser.Image = (Image)resources.GetObject("btnAddNewUser.Image");
            btnAddNewUser.Location = new Point(16, 530);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(137, 85);
            btnAddNewUser.TabIndex = 21;
            btnAddNewUser.UseVisualStyleBackColor = false;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // dgvListUsers
            // 
            dgvListUsers.AllowUserToAddRows = false;
            dgvListUsers.AllowUserToDeleteRows = false;
            dgvListUsers.AllowUserToOrderColumns = true;
            dgvListUsers.BackgroundColor = Color.FromArgb(242, 232, 242);
            dgvListUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvListUsers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SlateBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListUsers.ContextMenuStrip = cmUser;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListUsers.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListUsers.EnableHeadersVisualStyles = false;
            dgvListUsers.GridColor = Color.DarkViolet;
            dgvListUsers.Location = new Point(307, 63);
            dgvListUsers.Name = "dgvListUsers";
            dgvListUsers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(242, 232, 242);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvListUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvListUsers.RowHeadersVisible = false;
            dgvListUsers.RowHeadersWidth = 51;
            dgvListUsers.Size = new Size(910, 552);
            dgvListUsers.TabIndex = 17;
            dgvListUsers.DoubleClick += dgvListUsers_DoubleClick;
            // 
            // cmUser
            // 
            cmUser.ImageScalingSize = new Size(20, 20);
            cmUser.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewUserToolStripMenuItem, addNewUserToolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem, changePasswordToolStripMenuItem, toolStripMenuItem1, sendEmailToolStripMenuItem, phoneToolStripMenuItem, toolStripMenuItem3 });
            cmUser.Name = "cmUser";
            cmUser.Size = new Size(194, 208);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(193, 24);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(190, 6);
            // 
            // addNewUserToolStripMenuItem1
            // 
            addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            addNewUserToolStripMenuItem1.Size = new Size(193, 24);
            addNewUserToolStripMenuItem1.Text = "Add New User";
            addNewUserToolStripMenuItem1.Click += addNewUserToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(193, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(193, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(193, 24);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(190, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(193, 24);
            sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneToolStripMenuItem
            // 
            phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            phoneToolStripMenuItem.Size = new Size(193, 24);
            phoneToolStripMenuItem.Text = "Phone Call";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(193, 24);
            toolStripMenuItem3.Text = " ";
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = People.CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(16, 337);
            ccTextBoxSearch.Name = "ccTextBoxSearch";
            ccTextBoxSearch.Size = new Size(280, 27);
            ccTextBoxSearch.TabIndex = 20;
            ccTextBoxSearch.Visible = false;
            ccTextBoxSearch.TextChanged += ccTextBoxSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Lavender;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "User Name", "Is Active" });
            cbFilter.Location = new Point(113, 279);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(183, 28);
            cbFilter.TabIndex = 19;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 282);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 18;
            label1.Text = "FilterBy  :";
            // 
            // cbIsActive
            // 
            cbIsActive.BackColor = Color.Lavender;
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(113, 336);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(183, 28);
            cbIsActive.TabIndex = 26;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1224, 646);
            Controls.Add(cbIsActive);
            Controls.Add(lblRecordCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewUser);
            Controls.Add(dgvListUsers);
            Controls.Add(ccTextBoxSearch);
            Controls.Add(pictureBox1);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Users";
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListUsers).EndInit();
            cmUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecordCount;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Button btnAddNewUser;
        private DataGridView dgvListUsers;
        private People.CustomControl.ccTextBox ccTextBoxSearch;
        private PictureBox pictureBox1;
        private ComboBox cbFilter;
        private Label label1;
        private ComboBox cbIsActive;
        private ContextMenuStrip cmUser;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator addNewUserToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}