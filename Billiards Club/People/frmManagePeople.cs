using BilliardsBusinessLayer;
using BilliardsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.People
{
    public partial class frmManagePeople : Form
    {
        DataTable _dtAllPeople;
        DataTable _dtPeople;

        public frmManagePeople()
        {
            InitializeComponent();
        }
        private async Task _RefreshPeopleData()
        {
            _dtAllPeople = await clsPerson.GetAllPeopleAsync();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GenderCaption", "DateOfBirth",
                                                         "Phone", "Email");
            dgvListPeople.DataSource = _dtPeople;
            lblRecordCount.Text = dgvListPeople.RowCount.ToString();
            cmPerson.Enabled = dgvListPeople.RowCount > 0;
        }
        private async void frmManagePeople_Load(object sender, EventArgs e)
        {
            _dtAllPeople = await clsPerson.GetAllPeopleAsync();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GenderCaption", "DateOfBirth",
                                                         "Phone", "Email");
            dgvListPeople.DataSource = _dtPeople;
            if (dgvListPeople.Rows.Count > 0)
            {
                cbFilter.SelectedIndex = 0;
                if (dgvListPeople.Rows.Count > 0)
                {

                    dgvListPeople.Columns[0].HeaderText = "Person ID";
                    dgvListPeople.Columns[0].Width = 90;

                    dgvListPeople.Columns[1].HeaderText = "National No.";
                    dgvListPeople.Columns[1].Width = 90;


                    dgvListPeople.Columns[2].HeaderText = "First Name";
                    dgvListPeople.Columns[2].Width = 100;

                    dgvListPeople.Columns[3].HeaderText = "Second Name";
                    dgvListPeople.Columns[3].Width = 100;


                    dgvListPeople.Columns[4].HeaderText = "Third Name";
                    dgvListPeople.Columns[4].Width = 100;

                    dgvListPeople.Columns[5].HeaderText = "Last Name";
                    dgvListPeople.Columns[5].Width = 100;

                    dgvListPeople.Columns[6].HeaderText = "Gender";
                    dgvListPeople.Columns[6].Width = 90;

                    dgvListPeople.Columns[7].HeaderText = "Date Of Birth";
                    dgvListPeople.Columns[7].Width = 130;

                    dgvListPeople.Columns[8].HeaderText = "Phone";
                    dgvListPeople.Columns[8].Width = 110;


                    dgvListPeople.Columns[9].HeaderText = "Email";
                    dgvListPeople.Columns[9].Width = 140;
                }
                lblRecordCount.Text = dgvListPeople.RowCount.ToString();
                cmPerson.Enabled = dgvListPeople.RowCount > 0;

            }
        }

        private void ccTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Gender":
                    FilterColumn = "GenderCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (string.IsNullOrEmpty(ccTextBoxSearch.Text) || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }

            _dtPeople.DefaultView.RowFilter = (FilterColumn == "PersonID") ? $"[PersonID] = {ccTextBoxSearch.Text.Trim()}" : $"[{FilterColumn}] LIKE '{ccTextBoxSearch.Text.Trim()}%'";
            lblRecordCount.Text = dgvListPeople.Rows.Count.ToString();


        }

        private async void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccTextBoxSearch.Visible = cbFilter.SelectedIndex != 0;
            ccTextBoxSearch.Text = "";
            ccTextBoxSearch.InputType = cbFilter.SelectedItem == "Person ID" ? CustomControl.ccTextBox.InputTypeEnum.NumberInput : CustomControl.ccTextBox.InputTypeEnum.TextInput;
            await _RefreshPeopleData();
        }

        private async void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson())
            {
                frm.ShowDialog();
            }
            await _RefreshPeopleData();
        }

        private async void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmPersonDetails frm = new frmPersonDetails((int)dgvListPeople.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshPeopleData();
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddEditPerson frm = new frmAddEditPerson((int)dgvListPeople.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshPeopleData();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Are You Sure You Want To Delete This Person With ID " + PersonID, "Deleting Person", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (!await clsPerson.DeletePersonAsync(PersonID))
                {
                    MessageBox.Show("Delete Failed");
                }
                else
                    MessageBox.Show("Deleted Succefully");

            }
            else
                MessageBox.Show("Delete Failed Because this Person Has Data Linked To Him");
            await _RefreshPeopleData();
        }

        private void cmPerson_Opening(object sender, CancelEventArgs e)
        {
            sendEmailToolStripMenuItem.Enabled = !string.IsNullOrEmpty(dgvListPeople.CurrentRow.Cells["Email"].Value.ToString());
        }

        private async void dgvListPeople_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (frmPersonDetails frm = new frmPersonDetails((int)dgvListPeople.CurrentRow.Cells[0].Value))
            {
                frm.ShowDialog();
            }
            await _RefreshPeopleData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
