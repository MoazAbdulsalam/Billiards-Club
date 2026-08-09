namespace Pool_Club
{
    partial class ctrlPoolTable
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            gbTable = new GroupBox();
            lblAvailable = new Label();
            lblPlayer = new Label();
            lblTimer = new Label();
            btnEnd = new Button();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbTable.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Billiards_Club.Properties.Resources.pool;
            pictureBox1.Location = new Point(19, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbTable
            // 
            gbTable.BackColor = Color.FromArgb(242, 232, 242);
            gbTable.Controls.Add(lblAvailable);
            gbTable.Controls.Add(lblPlayer);
            gbTable.Controls.Add(lblTimer);
            gbTable.Controls.Add(btnEnd);
            gbTable.Controls.Add(btnStart);
            gbTable.Controls.Add(pictureBox1);
            gbTable.Font = new Font("Segoe UI", 12F);
            gbTable.ForeColor = Color.SlateBlue;
            gbTable.Location = new Point(3, 3);
            gbTable.Name = "gbTable";
            gbTable.Size = new Size(417, 306);
            gbTable.TabIndex = 1;
            gbTable.TabStop = false;
            gbTable.Text = "Table";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 14F);
            lblAvailable.ForeColor = Color.Green;
            lblAvailable.Location = new Point(306, 244);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(98, 32);
            lblAvailable.TabIndex = 5;
            lblAvailable.Text = "Availble";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 16F);
            lblPlayer.ForeColor = Color.Navy;
            lblPlayer.Location = new Point(19, 30);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(89, 37);
            lblPlayer.TabIndex = 4;
            lblPlayer.Text = "Player";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 24F);
            lblTimer.Location = new Point(64, 244);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(173, 54);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00:00";
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.SlateBlue;
            btnEnd.ForeColor = Color.White;
            btnEnd.Location = new Point(285, 131);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(119, 56);
            btnEnd.TabIndex = 2;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.SlateBlue;
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(285, 70);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(119, 55);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ctrlPoolTable
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(242, 232, 242);
            Controls.Add(gbTable);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "ctrlPoolTable";
            Size = new Size(423, 316);
            Load += ctrlPoolTable_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTable.ResumeLayout(false);
            gbTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox gbTable;
        private Button btnStart;
        private Label lblTimer;
        private Button btnEnd;
        private Label lblPlayer;
        private System.Windows.Forms.Timer timer1;
        private Label lblAvailable;
    }
}
