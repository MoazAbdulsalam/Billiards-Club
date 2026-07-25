using Billiards_Club.Classes;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Users
{
    public partial class frmLogin : Form
    {
        clsUser _User;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = "", password = "";
            if (clsGlobals.GetStoredCredential(ref username, ref password))
            {
                ccTextBoxUserName.Text = username;
                ccTextBoxPassword.Text = password;
                chbRememberMe.Checked = true;
            }
            else
                chbRememberMe.Checked = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ccTextBoxUserName.IsValid() || !ccTextBoxPassword.IsValid())
            {
                MessageBox.Show("Enter UserName And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User = await clsUser.FindByUserNameAndPasswordAsync(ccTextBoxUserName.Text, ccTextBoxPassword.Text);
            if (_User == null)
            {
                MessageBox.Show("UserName Or Password Is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_User.IsActive)
            {
                MessageBox.Show("User IS Not Active ,Contact Your Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chbRememberMe.Checked)
                clsGlobals.RememberUserNameAndPassword(ccTextBoxUserName.Text, ccTextBoxPassword.Text);
            else
                clsGlobals.RememberUserNameAndPassword("", "");
            clsGlobals.CurrentUser = _User;
            frmMain frm = new frmMain(this);

            frm.Show();
            this.Hide();
        }
        public void Clear()
        {
            ccTextBoxPassword.Text = "";
            ccTextBoxUserName.Text = "";
            chbRememberMe.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
