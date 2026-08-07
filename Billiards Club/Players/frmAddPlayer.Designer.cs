namespace Billiards_Club.Players
{
    partial class frmAddPlayer
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
            ctrlPersonCardWithFilter1 = new Billiards_Club.People.UserControls.ctrlPersonCardWithFilter();
            btnAddNewPlayer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(12, 64);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(834, 517);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // btnAddNewPlayer
            // 
            btnAddNewPlayer.BackColor = Color.FromArgb(126, 87, 194);
            btnAddNewPlayer.ForeColor = SystemColors.ButtonHighlight;
            btnAddNewPlayer.Image = Properties.Resources.AddPerson_32;
            btnAddNewPlayer.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewPlayer.Location = new Point(12, 596);
            btnAddNewPlayer.Name = "btnAddNewPlayer";
            btnAddNewPlayer.Size = new Size(834, 41);
            btnAddNewPlayer.TabIndex = 6;
            btnAddNewPlayer.Text = "Create New Player";
            btnAddNewPlayer.UseVisualStyleBackColor = false;
            btnAddNewPlayer.Click += btnAddNewPlayer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(255, 11);
            label1.Name = "label1";
            label1.Size = new Size(283, 50);
            label1.TabIndex = 7;
            label1.Text = "Add New Player";
            // 
            // frmAddPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 647);
            Controls.Add(label1);
            Controls.Add(btnAddNewPlayer);
            Controls.Add(ctrlPersonCardWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAddPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Player";
            Load += frmAddPlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private People.UserControls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Button btnAddNewPlayer;
        private Label label1;
    }
}