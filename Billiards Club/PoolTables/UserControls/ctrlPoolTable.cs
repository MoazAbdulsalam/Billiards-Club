using Billiards_Club.Players;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Billiards_Club.Players.Controls;
using Billiards_Club.Classes;
namespace Pool_Club
{
    public partial class ctrlPoolTable : UserControl
    {
        public class TableEventArgs : EventArgs
        {
            public clsPlayer Player { get; }
            public clsPayment Payment { get; }
            public clsPoolTable Table { get; }
            public TableEventArgs(clsPlayer player, clsPayment payment, clsPoolTable table)
            {
                Player = player;
                Payment = payment;
                Table = table;
            }
        }
        public event EventHandler<TableEventArgs> TableFinished;
        public event EventHandler<TableEventArgs> TableSelected;
        public void RaiseTableSelected(TableEventArgs e)
        {
            TableSelected?.Invoke(this, e);
        }
        public void RaiseTableFinished(TableEventArgs e)
        {
            TableFinished?.Invoke(this, e);
        }

        clsPlayer? Player;
        public clsPoolTableStatus PoolTableStatus { get; private set; }
        public ctrlPoolTable(clsPoolTableStatus tableStatus)
        {
            InitializeComponent();
            PoolTableStatus = tableStatus;

        }
        void UpdateUI()
        {
            gbTable.Text = "Table " + PoolTableStatus.Table.TableNumber;
            lblPlayer.Text = PoolTableStatus.CurrentPlayerName ?? "Player";
            btnStart.Enabled = PoolTableStatus.IsAvailable;
            lblAvailable.Text = PoolTableStatus.IsAvailable ? "Available" : "Occupied";
            lblAvailable.ForeColor = PoolTableStatus.IsAvailable ? Color.Green : Color.Red;
            if (PoolTableStatus.StartTime.HasValue)
            {
                TimeSpan elapsedTime = DateTime.Now - PoolTableStatus.StartTime.Value;
                lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                lblTimer.Text = "00:00:00";
            }
        }
        private void OnPlayerSelected(object sender, Billiards_Club.Players.Controls.ctrlPlayerCardWithFilter.OnPlayerSelectedEventArgs e)
        {
            Player = e.SelectedPlayer;
            if(Player!=null)
            {
                MessageBox.Show($"Player {Player.PersonInfo.FullName()} selected.", "Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Form)sender).Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!PoolTableStatus.StartTime.HasValue)
                return;

            TimeSpan elapsed =
                DateTime.Now - PoolTableStatus.StartTime.Value;

            lblTimer.Text = elapsed.ToString(@"hh\:mm\:ss");

        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!PoolTableStatus.IsAvailable)
            {
                MessageBox.Show("The session has already started.", "Session Already Started", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Player = null;
            using (frmSelectPlayer frm = new frmSelectPlayer())
            {
                frm.OnPlayerSelected += OnPlayerSelected;
                frm.ShowDialog();

            }
            int? PaymentID = null;

            if (Player != null)
            {
                  PaymentID = await PoolTableStatus.StartSessionAsync(Player, clsGlobals.CurrentUser.UserID.Value);

                if (PaymentID == null)
                {
                    MessageBox.Show("Failed to start the session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a player to start the session.", "Player Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PoolTableStatus.CurrentPlayerID = Player.PlayerID.Value;
            PoolTableStatus.CurrentPlayerName = Player.PersonInfo.FullName();
            UpdateUI();
            timer1.Start();
            clsPayment payment = await clsPayment.GetPaymentByPaymentIDAsync(PaymentID.Value);
            RaiseTableSelected(new TableEventArgs(Player, payment, PoolTableStatus.Table));
    
        }
        private async void btnEnd_Click(object sender, EventArgs e)
        {
            if (PoolTableStatus.IsAvailable)
            {
                MessageBox.Show("The session has not started yet.", "Session Not Started", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double totalAmount = PoolTableStatus.Table.CalculateFees(PoolTableStatus.StartTime.Value, DateTime.Now);
            if (MessageBox.Show($"Total amount due: ${totalAmount:F2}\nAre you sure you want to end the session?", "End Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            timer1.Stop();
            if (await PoolTableStatus.EndSessionAsync())
            {
                clsPayment? payment = await clsPayment.GetPaymentByPaymentIDAsync(PoolTableStatus.CurrentPaymentID.Value);
                RaiseTableFinished( new TableEventArgs( Player,payment,PoolTableStatus.Table) );
                PoolTableStatus.ResetTable();
                Player = null;
                UpdateUI();
                MessageBox.Show("Session ended successfully.", "Session Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                timer1.Start();
                MessageBox.Show("Failed to end the session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }
        private async void ctrlPoolTable_Load(object sender, EventArgs e)
        {
            if (PoolTableStatus.CurrentPlayerID.HasValue)
            {
                Player = await clsPlayer.FindPlayerByPersonIDAsync(PoolTableStatus.CurrentPlayerID.Value);
            }
            UpdateUI();

            if(!PoolTableStatus.IsAvailable)
            {
                timer1.Start();
            }
        }
    }
}
