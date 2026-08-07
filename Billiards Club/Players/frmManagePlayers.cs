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
    public partial class frmManagePlayers : Form
    {
        DataTable _dtPlayers;
        public frmManagePlayers()
        {
            InitializeComponent();
        }
        private async Task _RefreshPlayersData()
        {
            DataTable dt = await clsPlayer.GetAllPlayersAsync();
            _dtPlayers.Clear();
            _dtPlayers.Merge(dt);
            lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
        }

        private async void frmManagePlayers_Load(object sender, EventArgs e)
        {
            _dtPlayers = await clsPlayer.GetAllPlayersAsync();
            dgvListPlayers.DataSource = _dtPlayers;
            cbFilter.SelectedIndex = 0;
            if (dgvListPlayers.Rows.Count > 0)
            {
                dgvListPlayers.Columns[0].HeaderText = "Person ID";
                dgvListPlayers.Columns[0].Width = 100;

                dgvListPlayers.Columns[1].HeaderText = "Player ID";
                dgvListPlayers.Columns[1].Width = 100;

                dgvListPlayers.Columns[2].HeaderText = "Full Name";
                dgvListPlayers.Columns[2].Width = 220;

                dgvListPlayers.Columns[3].HeaderText = "Date Of Join";
                dgvListPlayers.Columns[3].Width = 150;

                dgvListPlayers.Columns[4].HeaderText = "Hours Played";
                dgvListPlayers.Columns[4].Width = 120;

                dgvListPlayers.Columns[5].HeaderText = "Money Paid";
                dgvListPlayers.Columns[5].Width = 120;

                dgvListPlayers.Columns[6].HeaderText = "Faviorate Table";
                dgvListPlayers.Columns[6].Width = 120;
            }
            lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccTextBoxSearch.Visible = (cbFilter.SelectedItem != "None");
            ccTextBoxSearch.InputType = cbFilter.SelectedItem == "Person ID" || cbFilter.SelectedItem == "Player ID" ? ccTextBox.InputTypeEnum.NumberInput : ccTextBox.InputTypeEnum.TextInput;

            ccTextBoxSearch.Clear();
            _dtPlayers.DefaultView.RowFilter = "";
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

                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (ccTextBoxSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPlayers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListPlayers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "PlayerID")
                _dtPlayers.DefaultView.RowFilter = $"[{FilterColumn}] ={ccTextBoxSearch.Text.Trim()}";
            else
                _dtPlayers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{ccTextBoxSearch.Text.Trim()}%'";
        }

        private async void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlayerDetails frm = new frmPlayerDetails((int)dgvListPlayers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            await _RefreshPlayersData();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Player With ID " + Convert.ToInt32(dgvListPlayers.CurrentRow.Cells[1].Value), "Deleting Player", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {

                if (!await clsPlayer.DeleteAsync(Convert.ToInt32(dgvListPlayers.CurrentRow.Cells[1].Value)))
                {
                    MessageBox.Show("Delete Failed");
                }
                else
                    MessageBox.Show("Deleted Succefully");

            }
            else
                MessageBox.Show("Delete Failed Because this Person Has Data Linked To Him");
            await _RefreshPlayersData();
        }

        private async void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            frmAddPlayer frm = new frmAddPlayer();
            frm.ShowDialog();
            await _RefreshPlayersData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
