namespace Billiards_Club.Players
{
    partial class frmSelectPlayer
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
            ctrlPlayerCardWithFilter1 = new Billiards_Club.Players.Controls.ctrlPlayerCardWithFilter();
            label1 = new Label();
            btnSelectPlayer = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // ctrlPlayerCardWithFilter1
            // 
            ctrlPlayerCardWithFilter1.BackColor = Color.FromArgb(242, 232, 242);
            ctrlPlayerCardWithFilter1.FilterEnabled = true;
            ctrlPlayerCardWithFilter1.Location = new Point(9, 48);
            ctrlPlayerCardWithFilter1.Name = "ctrlPlayerCardWithFilter1";
            ctrlPlayerCardWithFilter1.Size = new Size(1112, 560);
            ctrlPlayerCardWithFilter1.TabIndex = 0;
            ctrlPlayerCardWithFilter1.OnPlayerSelected += ctrlPlayerCardWithFilter1_OnPlayerSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(403, -5);
            label1.Name = "label1";
            label1.Size = new Size(228, 50);
            label1.TabIndex = 1;
            label1.Text = "Select Player";
            // 
            // btnSelectPlayer
            // 
            btnSelectPlayer.BackColor = Color.FromArgb(126, 87, 194);
            btnSelectPlayer.ForeColor = SystemColors.ControlLightLight;
            btnSelectPlayer.Image = Properties.Resources.Next_321;
            btnSelectPlayer.ImageAlign = ContentAlignment.MiddleRight;
            btnSelectPlayer.Location = new Point(821, 614);
            btnSelectPlayer.Name = "btnSelectPlayer";
            btnSelectPlayer.Size = new Size(300, 41);
            btnSelectPlayer.TabIndex = 6;
            btnSelectPlayer.Text = "SELECT";
            btnSelectPlayer.UseVisualStyleBackColor = false;
            btnSelectPlayer.Click += btnSelectPlayer_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(126, 87, 194);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Image = Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(496, 614);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(319, 40);
            btnClose.TabIndex = 37;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmSelectPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1133, 656);
            Controls.Add(btnClose);
            Controls.Add(btnSelectPlayer);
            Controls.Add(label1);
            Controls.Add(ctrlPlayerCardWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSelectPlayer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Player";
            Load += frmSelectPlayer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlPlayerCardWithFilter ctrlPlayerCardWithFilter1;
        private Label label1;
        private Button btnSelectPlayer;
        private Button btnClose;
    }
}