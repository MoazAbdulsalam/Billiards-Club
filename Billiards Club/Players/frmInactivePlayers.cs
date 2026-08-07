using Billiards_Club.People.CustomControl;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Players
{
    public partial class frmInactivePlayers : Form
    {
        DataTable _dtInactivePlayers;

        public frmInactivePlayers()
        {
            InitializeComponent();
        }


        private async Task _RefreshInactivePlayersData()
        {
            DataTable dt = await clsPlayer.GetInactivePlayersAsync();
            _dtInactivePlayers.Clear();
            _dtInactivePlayers.Merge(dt);
            lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
        }
        private async void frmInactivePlayers_Load(object sender, EventArgs e)
        {

            _dtInactivePlayers = await clsPlayer.GetInactivePlayersAsync();
            dgvListPlayers.DataSource = _dtInactivePlayers;
            cbFilter.SelectedIndex = 0;
            if (dgvListPlayers.Rows.Count > 0)
            {
                dgvListPlayers.Columns[0].HeaderText = "Person ID";
                dgvListPlayers.Columns[0].Width = 100;

                dgvListPlayers.Columns[1].HeaderText = "Player ID";
                dgvListPlayers.Columns[1].Width = 100;

                dgvListPlayers.Columns[2].HeaderText = "Full Name";
                dgvListPlayers.Columns[2].Width = 200;

                dgvListPlayers.Columns[3].HeaderText = "Date Of Join";
                dgvListPlayers.Columns[3].Width = 120;

                dgvListPlayers.Columns[4].HeaderText = "Hours Played";
                dgvListPlayers.Columns[4].Width = 100;

                dgvListPlayers.Columns[5].HeaderText = "Money Paid";
                dgvListPlayers.Columns[5].Width = 100;

                dgvListPlayers.Columns[6].HeaderText = "Faviorate Table";
                dgvListPlayers.Columns[6].Width = 100;

                dgvListPlayers.Columns[7].HeaderText = "Is Active";
                dgvListPlayers.Columns[7].Width = 100;
            }
            lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccTextBoxSearch.Visible = (cbFilter.SelectedItem != "None");
            ccTextBoxSearch.InputType = cbFilter.SelectedItem == "Person ID" || cbFilter.SelectedItem == "Player ID" ? ccTextBox.InputTypeEnum.NumberInput : ccTextBox.InputTypeEnum.TextInput;

            ccTextBoxSearch.Clear();
            _dtInactivePlayers.DefaultView.RowFilter = "";
        }
        private void ccTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Player ID":
                    FilterColumn = "PlayerID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (ccTextBoxSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInactivePlayers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "PlayerID")
                _dtInactivePlayers.DefaultView.RowFilter = $"[{FilterColumn}] ={ccTextBoxSearch.Text.Trim()}";
            else
                _dtInactivePlayers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{ccTextBoxSearch.Text.Trim()}%'";
        }
        async Task _RestorePlayerAsync()
        {
            int PlayerID = +Convert.ToInt32(dgvListPlayers.CurrentRow.Cells[1].Value);
            if (MessageBox.Show("Are You Sure You Want To Restore This Player ?" + PlayerID, "Confirm Restore", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!await clsPlayer.RestorePlayerAsync(PlayerID))
                {
                    MessageBox.Show("Restore Failed");

                }
                else
                    MessageBox.Show("Restored Succefully");

            }
            await _RefreshInactivePlayersData();
        }
        private async void RestorePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await _RestorePlayerAsync();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void RestorePlayerToolStripMenuItem_Click(object sender, DataGridViewCellEventArgs e)
        {
            await _RestorePlayerAsync();
        }

        private void cmPlayer_Opening(object sender, CancelEventArgs e)
        {
            RestorePlayerToolStripMenuItem.Enabled = dgvListPlayers.Rows.Count > 0;
        }
    }
}
