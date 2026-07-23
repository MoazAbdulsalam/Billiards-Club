using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pool_Club
{
    public partial class ctrlPoolTable : UserControl
    {
        public class TableEventArgs : EventArgs
        {
            public int TotalSeconds { get; }
            public string TimeConsumed { get; }
            public double HourlyRate { get; }
            public double Fees()
            {
                return ((double)TotalSeconds / (60 * 60)) * HourlyRate;
            }
            public TableEventArgs(double HourlyRate, int TotalSeconds, string TimeConsumed)
            {
                this.HourlyRate = HourlyRate;
                this.TotalSeconds = TotalSeconds;
                this.TimeConsumed = TimeConsumed;
            }
        }
        public event EventHandler<TableEventArgs> TableFinished;
        public void RaiseTableFinished(TableEventArgs e)
        {
            TableFinished?.Invoke(this, e);
        }


        double _HourlyRate = 10;
        string _playerName="Player";
        string _TableName;
        int _Seconds = 0;
        [ Category("Pool Configeration."), Description("Player Name") ]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PlayerName { get { return _playerName; } set { lblPlayer.Text = value; _playerName = value; Invalidate(); } }
        [Category("Pool Configeration."), Description("Table Name")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TableName { get { return _TableName; } set { gbTable.Text = value; _TableName = value; Invalidate(); } }
        [Category("Pool Configeration."), Description("Rate Per Hour")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public double HourlyRate { get { return _HourlyRate; } set { _HourlyRate = value; } }


        public ctrlPoolTable()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;
            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
            lblTimer.Refresh();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                timer1.Stop();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            RaiseTableFinished(new TableEventArgs(HourlyRate, _Seconds, lblTimer.Text));
            lblPlayer.Text = "Player";
            lblTimer.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _Seconds = 0;

        }

        private void ctrlPoolTable_Load(object sender, EventArgs e)
        {

        }
    }
}
