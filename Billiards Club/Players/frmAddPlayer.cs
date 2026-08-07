using Billiards_Club.Classes;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Players
{
    public partial class frmAddPlayer : Form
    {
        public delegate void DataBackEventHandler(object sender, int PlayerID);
        public event DataBackEventHandler DataBack;
        clsPlayer? _Player;
        int? _PersonID = null;
        public frmAddPlayer()
        {
            InitializeComponent();
        }

        private async void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (_PersonID == null)
            {
                MessageBox.Show("Please select a person first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Player = new clsPlayer();
            _Player.PersonID = _PersonID.Value;
            _Player.CreatedByUserID =  clsGlobals.CurrentUser.UserID.Value;
            try
            {
                if (await _Player.SaveAsync())
                {
                    MessageBox.Show("Player added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBack?.Invoke(this, _Player.PlayerID.Value);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add player.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }


        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, Billiards_Club.People.UserControls.ctrlPersonCardWithFilter.OnPersonSelectedEventArgs e)
        {
            _PersonID = e.PersonID;
            btnAddNewPlayer.Enabled = _PersonID.HasValue;
        }

        private void frmAddPlayer_Load(object sender, EventArgs e)
        {
            btnAddNewPlayer.Enabled = false;
        }
    }
}
