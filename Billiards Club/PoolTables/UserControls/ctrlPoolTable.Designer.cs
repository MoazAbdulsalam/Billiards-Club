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
            lblPlayer = new Label();
            lblTimer = new Label();
            btnEnd = new Button();
            btnStartStop = new Button();
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
            pictureBox1.Size = new Size(238, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbTable
            // 
            gbTable.BackColor = Color.Black;
            gbTable.Controls.Add(lblPlayer);
            gbTable.Controls.Add(lblTimer);
            gbTable.Controls.Add(btnEnd);
            gbTable.Controls.Add(btnStartStop);
            gbTable.Controls.Add(pictureBox1);
            gbTable.ForeColor = SystemColors.ControlLightLight;
            gbTable.Location = new Point(3, 3);
            gbTable.Name = "gbTable";
            gbTable.Size = new Size(384, 291);
            gbTable.TabIndex = 1;
            gbTable.TabStop = false;
            gbTable.Text = "Table";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(146, 23);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(65, 28);
            lblPlayer.TabIndex = 4;
            lblPlayer.Text = "Player";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(78, 239);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(119, 38);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00:00";
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Black;
            btnEnd.Location = new Point(271, 131);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(94, 43);
            btnEnd.TabIndex = 2;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.Black;
            btnStartStop.Location = new Point(271, 70);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(94, 43);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStart_Click;
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
            BackColor = Color.Black;
            Controls.Add(gbTable);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "ctrlPoolTable";
            Size = new Size(404, 317);
            Load += ctrlPoolTable_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbTable.ResumeLayout(false);
            gbTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox gbTable;
        private Button btnStartStop;
        private Label lblTimer;
        private Button btnEnd;
        private Label lblPlayer;
        private System.Windows.Forms.Timer timer1;
    }
}
