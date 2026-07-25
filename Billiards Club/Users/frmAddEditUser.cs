using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Billiards_Club.People.frmAddEditPerson;

namespace Billiards_Club.Users
{
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew, Update }
        public enMode Mode;
        int? _UserID = null;
        int? _PersonID = null;
        clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }
        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            _UserID = userID;
        }
        async Task _LoadDataAsync()
        {
            _User = await clsUser.FindByUserIDAsync(_UserID.Value);
            if (_User == null)
            {
                MessageBox.Show("User not Found");
                this.Close();
                return;
            }
            lblHeader.Text = "   Update User";
            await ctrlPersonCardWithFilter1.LoadPersonInfoAsync(_User.PersonID);
            ccTextBoxUserName.Text = _User.UserName;
            ccTextBoxPassword.Text = _User.Password;
            ccTextBoxConfirmPassword.Text = _User.Password;
            lblUserID.Text = _UserID.ToString();
            chbIsActive.Checked = _User.IsActive;
        }

        private async void frmAddEditUser_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {

                await _LoadDataAsync();
                ctrlPersonCardWithFilter1.FilterEnabled = false;
                panelPassword.Visible = false;
            }

            else
            {
                tpLoginInfo.Enabled = false;
                btnNext.Enabled = false;
            }

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, Billiards_Club.People.UserControls.ctrlPersonCardWithFilter.OnPersonSelectedEventArgs e)
        {
            _PersonID = e.PersonID;
            btnNext.Enabled = _PersonID != null;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID == null)
            {
                MessageBox.Show("User Must Be a Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tpLoginInfo.Enabled = false;
                return;
            }
            if (await clsUser.IsUserExistForPersonIDAsync(_PersonID.Value) && Mode == enMode.AddNew)
            {
                MessageBox.Show("This Person Already a User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tpLoginInfo.Enabled = false;

                return;
            }
            tpLoginInfo.Enabled = true;
            tabControl1.SelectedIndex = 1;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Complete Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Mode == enMode.AddNew)
            {
                _User = new clsUser(_PersonID.Value, ccTextBoxUserName.Text, ccTextBoxPassword.Text, chbIsActive.Checked);
            }
            else
            {
                _User.UserName = ccTextBoxUserName.Text;
                _User.IsActive = chbIsActive.Checked;
            }

            if (await _User.SaveAsync())
            {
                MessageBox.Show(" Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = enMode.Update;
                lblHeader.Text = "   Update User";
                lblUserID.Text = _User.UserID.ToString();
            }
            else
                MessageBox.Show("Save Failed", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void ccTextBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (!ccTextBoxUserName.IsValid())
            {
                errorProvider1.SetError(ccTextBoxUserName, "UserName is Required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxUserName, "");
                e.Cancel = false;
            }

            if (await clsUser.IsUserExistForPersonIDAsync(_PersonID.Value))
            {
                errorProvider1.SetError(ccTextBoxUserName, "UserName Taken");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxUserName, "");
                e.Cancel = false;
            }

            if (ccTextBoxUserName.Text.Length < 4)
            {
                errorProvider1.SetError(ccTextBoxUserName, "UserName Must be > 4");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxUserName, "");
                e.Cancel = false;
            }
        }

        private void ccTextBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ccTextBoxPassword.Text.Length < 4)
            {
                errorProvider1.SetError(ccTextBoxPassword, "Password Must be > 4");
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ccTextBoxPassword, "");
            }
        }

        private void ccTextBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!ccTextBoxConfirmPassword.IsValid())
            {
                errorProvider1.SetError(ccTextBoxConfirmPassword, "UserName is Required");
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxConfirmPassword, "");
                e.Cancel = false;
            }

            if (ccTextBoxConfirmPassword.Text != ccTextBoxPassword.Text)
            {
                errorProvider1.SetError(ccTextBoxConfirmPassword, "Wrong Password");
                e.Cancel = true;
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ccTextBoxConfirmPassword, "");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
