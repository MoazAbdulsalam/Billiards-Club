namespace Billiards_Club.Players.Controls
{
    partial class ctrlPlayerCard
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
            ctrlPersonCard1 = new Billiards_Club.People.UserControls.ctrlPersonCard();
            gbPlayerInfo = new GroupBox();
            label1 = new Label();
            lblPlayerID = new Label();
            label3 = new Label();
            lblDateOfJoin = new Label();
            label5 = new Label();
            lblCreatedByUserID = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTotslHoursPlayed = new Label();
            label10 = new Label();
            lblTotalMoneyPaid = new Label();
            label12 = new Label();
            lblFavoriteTable = new Label();
            gbPlayerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPersonCard1.Location = new Point(3, 3);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(809, 436);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbPlayerInfo
            // 
            gbPlayerInfo.BackColor = Color.FromArgb(242, 232, 242);
            gbPlayerInfo.Controls.Add(lblFavoriteTable);
            gbPlayerInfo.Controls.Add(label12);
            gbPlayerInfo.Controls.Add(lblTotalMoneyPaid);
            gbPlayerInfo.Controls.Add(label10);
            gbPlayerInfo.Controls.Add(lblTotslHoursPlayed);
            gbPlayerInfo.Controls.Add(label8);
            gbPlayerInfo.Controls.Add(label7);
            gbPlayerInfo.Controls.Add(lblCreatedByUserID);
            gbPlayerInfo.Controls.Add(label5);
            gbPlayerInfo.Controls.Add(lblDateOfJoin);
            gbPlayerInfo.Controls.Add(label3);
            gbPlayerInfo.Controls.Add(lblPlayerID);
            gbPlayerInfo.Controls.Add(label1);
            gbPlayerInfo.Location = new Point(818, 12);
            gbPlayerInfo.Name = "gbPlayerInfo";
            gbPlayerInfo.Size = new Size(284, 414);
            gbPlayerInfo.TabIndex = 1;
            gbPlayerInfo.TabStop = false;
            gbPlayerInfo.Text = "Player Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Player ID :";
            // 
            // lblPlayerID
            // 
            lblPlayerID.AutoSize = true;
            lblPlayerID.Location = new Point(172, 48);
            lblPlayerID.Name = "lblPlayerID";
            lblPlayerID.Size = new Size(30, 20);
            lblPlayerID.TabIndex = 1;
            lblPlayerID.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 105);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Date Of Join :";
            // 
            // lblDateOfJoin
            // 
            lblDateOfJoin.AutoSize = true;
            lblDateOfJoin.Location = new Point(172, 105);
            lblDateOfJoin.Name = "lblDateOfJoin";
            lblDateOfJoin.Size = new Size(30, 20);
            lblDateOfJoin.TabIndex = 3;
            lblDateOfJoin.Text = "???";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 162);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Created By User:";
            // 
            // lblCreatedByUserID
            // 
            lblCreatedByUserID.AutoSize = true;
            lblCreatedByUserID.Location = new Point(172, 162);
            lblCreatedByUserID.Name = "lblCreatedByUserID";
            lblCreatedByUserID.Size = new Size(30, 20);
            lblCreatedByUserID.TabIndex = 5;
            lblCreatedByUserID.Text = "???";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 213);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Statistics :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 267);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 7;
            label8.Text = "Total Hours Played :";
            // 
            // lblTotslHoursPlayed
            // 
            lblTotslHoursPlayed.AutoSize = true;
            lblTotslHoursPlayed.Location = new Point(172, 267);
            lblTotslHoursPlayed.Name = "lblTotslHoursPlayed";
            lblTotslHoursPlayed.Size = new Size(30, 20);
            lblTotslHoursPlayed.TabIndex = 8;
            lblTotslHoursPlayed.Text = "???";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 318);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 9;
            label10.Text = "Total Money Paid :";
            // 
            // lblTotalMoneyPaid
            // 
            lblTotalMoneyPaid.AutoSize = true;
            lblTotalMoneyPaid.Location = new Point(172, 318);
            lblTotalMoneyPaid.Name = "lblTotalMoneyPaid";
            lblTotalMoneyPaid.Size = new Size(30, 20);
            lblTotalMoneyPaid.TabIndex = 10;
            lblTotalMoneyPaid.Text = "???";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 372);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 11;
            label12.Text = "Favorite Table :";
            // 
            // lblFavoriteTable
            // 
            lblFavoriteTable.AutoSize = true;
            lblFavoriteTable.Location = new Point(172, 372);
            lblFavoriteTable.Name = "lblFavoriteTable";
            lblFavoriteTable.Size = new Size(30, 20);
            lblFavoriteTable.TabIndex = 12;
            lblFavoriteTable.Text = "???";
            // 
            // ctrlPlayerCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 232, 242);
            Controls.Add(gbPlayerInfo);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPlayerCard";
            Size = new Size(1113, 440);
            gbPlayerInfo.ResumeLayout(false);
            gbPlayerInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.UserControls.ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbPlayerInfo;
        private Label lblCreatedByUserID;
        private Label label5;
        private Label lblDateOfJoin;
        private Label label3;
        private Label lblPlayerID;
        private Label label1;
        private Label lblFavoriteTable;
        private Label label12;
        private Label lblTotalMoneyPaid;
        private Label label10;
        private Label lblTotslHoursPlayed;
        private Label label8;
        private Label label7;
    }
}
