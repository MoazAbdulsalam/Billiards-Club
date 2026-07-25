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
    using System.Drawing;
    using System.Windows.Forms;


    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmManagePeople frm = new frmManagePeople())
                frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.BackColor = Color.BlueViolet;
            menuStrip1.ForeColor = Color.White;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmManageUsers frm = new frmManageUsers())
                frm.ShowDialog();
        }
    }
}
