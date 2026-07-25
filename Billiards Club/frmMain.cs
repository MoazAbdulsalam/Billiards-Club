using Billiards_Club.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club
{
    using Billiards_Club.Classes;
    using Billiards_Club.Users;
    using System.Drawing;
    using System.Windows.Forms;


    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmManagePeople frm = new frmManagePeople())
                frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            //menuStrip1.BackColor = Color.BlueViolet;
            //menuStrip1.ForeColor = Color.White;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmManageUsers frm = new frmManageUsers())
                frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (clsGlobals.CurrentUser != null)
                Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(frmChangePassword frm = new frmChangePassword(clsGlobals.CurrentUser.UserID.Value))
                frm.ShowDialog();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmUserInfo frm = new frmUserInfo(clsGlobals.CurrentUser.UserID.Value))
                frm.ShowDialog();
        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobals.CurrentUser = null;
            _frmLogin.Clear();
            _frmLogin.Show();
            this.Close();
        }
    }
}
