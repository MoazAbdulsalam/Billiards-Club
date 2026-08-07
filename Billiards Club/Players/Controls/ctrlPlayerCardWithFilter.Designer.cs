namespace Billiards_Club.Players.Controls
{
    partial class ctrlPlayerCardWithFilter
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
            gbFilter = new GroupBox();
            btnAddNewPlayer = new Button();
            btnSearch = new Button();
            ccTextBoxSearch = new Billiards_Club.People.CustomControl.ccTextBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            ctrlPlayerCard1 = new ctrlPlayerCard();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.BackColor = Color.FromArgb(242, 232, 242);
            gbFilter.Controls.Add(btnAddNewPlayer);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(ccTextBoxSearch);
            gbFilter.Controls.Add(cbFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(3, 14);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(795, 100);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter :";
            // 
            // btnAddNewPlayer
            // 
            btnAddNewPlayer.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewPlayer.Image = Properties.Resources.AddPerson_32;
            btnAddNewPlayer.Location = new Point(617, 36);
            btnAddNewPlayer.Name = "btnAddNewPlayer";
            btnAddNewPlayer.Size = new Size(60, 41);
            btnAddNewPlayer.TabIndex = 5;
            btnAddNewPlayer.UseVisualStyleBackColor = false;
            btnAddNewPlayer.Click += btnAddNewPlayer_Click_1;
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
            btnSearch.Click += btnSearch_Click_1;
            // 
            // ccTextBoxSearch
            // 
            ccTextBoxSearch.InputType = People.CustomControl.ccTextBox.InputTypeEnum.NumberInput;
            ccTextBoxSearch.IsRequired = true;
            ccTextBoxSearch.Location = new Point(265, 40);
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
            cbFilter.Items.AddRange(new object[] { "PersonID", "PlayerID" });
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
            // ctrlPlayerCard1
            // 
            ctrlPlayerCard1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPlayerCard1.Location = new Point(0, 123);
            ctrlPlayerCard1.Name = "ctrlPlayerCard1";
            ctrlPlayerCard1.Size = new Size(1117, 443);
            ctrlPlayerCard1.TabIndex = 3;
            // 
            // ctrlPlayerCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 242);
            Controls.Add(ctrlPlayerCard1);
            Controls.Add(gbFilter);
            Name = "ctrlPlayerCardWithFilter";
            Size = new Size(1116, 566);
            Load += ctrlPlayerCardWithFilter_Load;
            KeyDown += ctrlPlayerCardWithFilter_KeyDown;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilter;
        private Button btnAddNewPlayer;
        private Button btnSearch;
        private People.CustomControl.ccTextBox ccTextBoxSearch;
        private ComboBox cbFilter;
        private Label label1;
        private ctrlPlayerCard ctrlPlayerCard1;
    }
}
