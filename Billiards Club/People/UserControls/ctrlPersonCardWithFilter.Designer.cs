namespace Billiards_Club.People.UserControls
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilter = new GroupBox();
            btnAddNewPerson = new Button();
            btnSearch = new Button();
            ccTextBoxSearch = new Billiards_Club.People.CustomControl.ccTextBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.Lavender;
            ctrlPersonCard1.Location = new Point(2, 100);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(797, 417);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddNewPerson);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(ccTextBoxSearch);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(4, -2);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(795, 100);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter :";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewPerson.Image = Properties.Resources.AddPerson_32;
            btnAddNewPerson.Location = new Point(617, 36);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(60, 41);
            btnAddNewPerson.TabIndex = 5;
            btnAddNewPerson.UseVisualStyleBackColor = false;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(126, 87, 194);
            btnSearch.Image = Properties.Resources.SearchPerson;
            btnSearch.Location = new Point(551, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 41);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = CustomControl.ccTextBox.InputTypeEnum.TextInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(265, 40);
            ccTextBoxSearch.Name = "ccTextBoxSearch";
            ccTextBoxSearch.Size = new Size(280, 34);
            ccTextBoxSearch.TabIndex = 3;
            ccTextBoxSearch.TextChanged += ccTextBoxSearch_TextChanged;
            ccTextBoxSearch.KeyDown += ccTextBoxSearch_KeyDown;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.Lavender;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "PersonID", "NationalNo." });
            cbFilter.Location = new Point(99, 40);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 36);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 1;
            label1.Text = "FilterBy  :";
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 232, 242);
            Controls.Add(gbFilter);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(861, 519);
            Load += ctrlPersonCardWithFilter1_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // private ctrlPersonCard ctrlPersonCard2;
        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilter;
        private ComboBox cbFilter;
        private Label label1;
        private Button btnAddNewPerson;
        private Button btnSearch;
        private CustomControl.ccTextBox ccTextBoxSearch;
    }
}
