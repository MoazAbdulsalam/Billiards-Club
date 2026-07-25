using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Users
{
    public partial class frmUserInfo : Form
    {
        int _UserID;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmUserInfo_Load(object sender, EventArgs e)
        {
           await ctrlUserInfo1.LoadUserAsync(_UserID);
        }
    }
}
