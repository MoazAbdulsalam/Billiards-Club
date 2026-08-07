using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Billiards_Club.Players.Enums;


namespace Billiards_Club.Players
{
    public partial class frmPlayerDetails : Form
    {
        int _PlayerID;
        DataTable _PlayerPayments;

        public frmPlayerDetails(int PlayerID)
        {
            InitializeComponent();
            _PlayerID = PlayerID;
        }

        private async void frmPlayerDetails_Load(object sender, EventArgs e)
        {
            await ctrlPlayerCard1.LoadPlayerInfoAsync(_PlayerID, eFindBy.PlayerID);
            _PlayerPayments = await ctrlPlayerCard1.SelectedPlayerInfo.GetPlayerPaymentsAsync();
            dgvListPlayerPayments.DataSource = _PlayerPayments;

            if (dgvListPlayerPayments.Rows.Count > 0)
            {
                dgvListPlayerPayments.Columns[0].HeaderText = "Payment ID";
                dgvListPlayerPayments.Columns[0].Width = 150;

                dgvListPlayerPayments.Columns[1].HeaderText = "Date Of Payment";
                dgvListPlayerPayments.Columns[1].Width = 190;

                dgvListPlayerPayments.Columns[2].HeaderText = "Table Number";
                dgvListPlayerPayments.Columns[2].Width = 150;

                dgvListPlayerPayments.Columns[3].HeaderText = "Table Price Per Hour";
                dgvListPlayerPayments.Columns[3].Width = 170;

                dgvListPlayerPayments.Columns[4].HeaderText = "Time Played";
                dgvListPlayerPayments.Columns[4].Width = 140;

                dgvListPlayerPayments.Columns[5].HeaderText = "Fees";
                dgvListPlayerPayments.Columns[5].Width = 150;
            }
            lblRecordCount.Text = dgvListPlayerPayments.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
