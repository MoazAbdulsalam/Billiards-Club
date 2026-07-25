using BilliardsBusinessLayer;
using SharedUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User;
        public frmChangePassword(int UserId)
        {
            InitializeComponent();
            _UserID = UserId;
        }

        private async void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User = await clsUser.FindByUserIDAsync(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User Exist With ID = " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            await ctrlUserInfo1.LoadUserAsync(_UserID);
        }

        private void ccTextBoxOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!ccTextBoxOldPassword.IsValid())
            {
                errorProvider1.SetError(ccTextBoxOldPassword, "Complete Required Field");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxOldPassword, "");
                e.Cancel = false;
            }

            if (clsCryptography.ComputeHash(ccTextBoxOldPassword.Text.Trim()) != _User.Password)
            {
                errorProvider1.SetError(ccTextBoxOldPassword, "Wrong Password");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(ccTextBoxOldPassword, "");
                e.Cancel = false;
            }
        }

        private void ccTextBoxNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ccTextBoxNewPassword.Text.Length < 4)
            {
                errorProvider1.SetError(ccTextBoxNewPassword, "Password Must be > 4");
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ccTextBoxNewPassword, "");
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

            if (ccTextBoxConfirmPassword.Text != ccTextBoxNewPassword.Text)
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Complete Requaired Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (await _User.ChangePasswordAsync(ccTextBoxNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Succefully", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Password Change Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
