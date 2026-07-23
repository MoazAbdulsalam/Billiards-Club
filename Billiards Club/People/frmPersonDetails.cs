using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.People
{
    public partial class frmPersonDetails : Form
    {
        int _PersonID;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmPersonDetails_Load(object sender, EventArgs e)
        {
            await ctrlPersonCard1.LoadPersonAsync(_PersonID);
        }
    }
}
