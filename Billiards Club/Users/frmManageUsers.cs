using Billiards_Club.People.CustomControl;
using Billiards_Club.Users;
using BilliardsBusinessLayer;
using BilliardsDataAccessLayer;
using Microsoft.Data.SqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Billiards_Club
{
    public partial class frmManageUsers : Form
    {
        DataTable _dtUsers;
        public frmManageUsers()
        {
            InitializeComponent();
        }
        private async Task _RefreshUsersData()
        {
            DataTable dt = await clsUser.GetAllUsersAsync();
            _dtUsers.Clear();
            _dtUsers.Merge(dt);
            lblRecordCount.Text = dgvListUsers.Rows.Count.ToString();
        }
        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtUsers = await clsUser.GetAllUsersAsync();
            dgvListUsers.DataSource = _dtUsers;
            cbFilter.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;
            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 140;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 140;

                dgvListUsers.Columns[2].HeaderText = "Full Name";
                dgvListUsers.Columns[2].Width = 350;

                dgvListUsers.Columns[3].HeaderText = "UserName";
                dgvListUsers.Columns[3].Width = 150;

                dgvListUsers.Columns[4].HeaderText = "Is Active";
                dgvListUsers.Columns[4].Width = 120;
            }
            lblRecordCount.Text = dgvListUsers.Rows.Count.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccTextBoxSearch.Visible = (cbFilter.SelectedItem != "None") && (cbFilter.SelectedItem != "Is Active");
            cbIsActive.Visible = cbFilter.SelectedItem == "Is Active";
            ccTextBoxSearch.InputType = cbFilter.SelectedItem == "Person ID" || cbFilter.SelectedItem == "User ID" ? ccTextBox.InputTypeEnum.NumberInput : ccTextBox.InputTypeEnum.TextInput;

            ccTextBoxSearch.Clear();
            _dtUsers.DefaultView.RowFilter = "";
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbIsActive.SelectedItem)
            {
                case "All":
                    _dtUsers.DefaultView.RowFilter = "";
                    break;
                case "Yes":
                    _dtUsers.DefaultView.RowFilter = "[IsActive] = 'True'";
                    break;
                case "No":
                    _dtUsers.DefaultView.RowFilter = "[IsActive] = 'False'";
                    break;
            }
            lblRecordCount.Text = dgvListUsers.RowCount.ToString();
        }

        private void ccTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "User Name":
                    FilterColumn = "UserName";

                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (ccTextBoxSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListUsers.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] ={ccTextBoxSearch.Text.Trim()}";
            else
                _dtUsers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{ccTextBoxSearch.Text.Trim()}%'";
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This User With ID " + Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value), "Deleting Person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (!await clsUser.DeleteUserAsync(Convert.ToInt32(dgvListUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Delete Failed");
                }
                else
                    MessageBox.Show("Deleted Succefully");

            }
            else
                MessageBox.Show("Delete Failed Because this Person Has Data Linked To Him");
            await _RefreshUsersData();
        }

        private async void addNewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser())
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser((int)dgvListUsers.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }

        private async void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmChangePassword frm = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }

        private async void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmUserInfo frm = new frmUserInfo((int)dgvListUsers.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }

        private async void btnAddNewUser_Click(object sender, EventArgs e)
        {
            using (frmAddEditUser frm = new frmAddEditUser())
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvListUsers_DoubleClick(object sender, EventArgs e)
        {
            using (frmUserInfo frm = new frmUserInfo((int)dgvListUsers.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshUsersData();
        }
    }
}
