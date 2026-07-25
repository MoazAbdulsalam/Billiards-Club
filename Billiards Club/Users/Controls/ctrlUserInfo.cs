using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BilliardsBusinessLayer;
namespace Billiards_Club.Users.Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        int? _UserID;
        clsUser _User;
        public int? UserID { get { return _UserID; } }
        public clsUser User { get { return _User; } }

        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        async Task _LoadData()
        {
             await  ctrlPersonCard1.LoadPersonAsync(_User.PersonID);
            _UserID =User.UserID;

            lblUserName.Text = _User.UserName.ToString();
            lblIsActive.Text = _User.IsActive.ToString();
            lblUserID.Text = _User.UserID.ToString();
        }
        public async Task LoadUserAsync(int UserID)
        {
            _User = await clsUser.FindByUserIDAsync(UserID);
            if( _User == null )
            {
                MessageBox.Show("No Person With PersonID =" + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LoadData();
        }

    }
}
