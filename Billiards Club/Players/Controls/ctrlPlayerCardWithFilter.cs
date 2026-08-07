using Billiards_Club.People;
using Billiards_Club.People.UserControls;
using BilliardsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Billiards_Club.Players.Controls
{
    public partial class ctrlPlayerCardWithFilter : UserControl
    {
        public class OnPlayerSelectedEventArgs : EventArgs
        {
            public int? PlayerID { get; }
            public clsPlayer? SelectedPlayer { get; }
            public OnPlayerSelectedEventArgs(int? PlayerId, clsPlayer? SelectedPlayer)
            {
                this.PlayerID = PlayerId;
                this.SelectedPlayer = SelectedPlayer;
            }
        }
        public event EventHandler<OnPlayerSelectedEventArgs> OnPlayerSelected;
        protected virtual void RaiseOnPlayerSelected(OnPlayerSelectedEventArgs e)
        {
            OnPlayerSelected?.Invoke(this, e);
        }


        private bool _FilterEnabled = true;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value; gbFilter.Enabled = _FilterEnabled; }
        }
        public clsPlayer SelectedPlayerInfo { get { return ctrlPlayerCard1.SelectedPlayerInfo; } }

        Enums.eFindBy _FindBy;

        public ctrlPlayerCardWithFilter()
        {
            InitializeComponent();
        }
        public Task LoadPlayerInfoAsync(int PlayerID)
        {
            cbFilter.SelectedIndex = 1;
            ccTextBoxSearch.Text = PlayerID.ToString();
            return _FindPlayerAsync();
        }

        async Task _FindPlayerAsync()
        {
            if (!ccTextBoxSearch.IsValid())
                return;
            await ctrlPlayerCard1.LoadPlayerInfoAsync(int.Parse(ccTextBoxSearch.Text), _FindBy);

            RaiseOnPlayerSelected(new OnPlayerSelectedEventArgs(ctrlPlayerCard1.PlayerID, ctrlPlayerCard1.SelectedPlayerInfo));
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FindBy = (Enums.eFindBy)cbFilter.SelectedIndex;
            ccTextBoxSearch.Text = "";
            ctrlPlayerCard1.Refresh();
        }


        private void ccTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ccTextBoxSearch.IsValid())
            {
                btnSearch.Enabled = true;

            }
            else
                btnSearch.Enabled = false;
        }


        public void FilterFocus()
        {
            ccTextBoxSearch.Focus();
        }

        private void ctrlPlayerCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            btnSearch.Enabled = false;
        }

        private async void ctrlPlayerCardWithFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await _FindPlayerAsync();
            }
        }
        async void _DataBackEvent(object sender, int PlayerID)
        {
            await LoadPlayerInfoAsync(PlayerID);
        }

        private void btnAddNewPlayer_Click_1(object sender, EventArgs e)
        {
            frmAddPlayer frm = new frmAddPlayer();
            frm.DataBack += _DataBackEvent;
            frm.ShowDialog();
        }

        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            await _FindPlayerAsync();

        }
    }
}
