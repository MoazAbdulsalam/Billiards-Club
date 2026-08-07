using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Billiards_Club.Players.Controls.ctrlPlayerCardWithFilter;

namespace Billiards_Club.Players
{
    public partial class frmSelectPlayer : Form
    {
        public event EventHandler<OnPlayerSelectedEventArgs> OnPlayerSelected;
        protected virtual void RaiseOnPlayerSelected(OnPlayerSelectedEventArgs e)
        {
            OnPlayerSelected?.Invoke(this, e);
        }
        public frmSelectPlayer()
        {
            InitializeComponent();
        }

        private void ctrlPlayerCardWithFilter1_OnPlayerSelected(object sender, Billiards_Club.Players.Controls.ctrlPlayerCardWithFilter.OnPlayerSelectedEventArgs e)
        {
            btnSelectPlayer.Enabled = e.PlayerID.HasValue;

        }

        private void frmSelectPlayer_Load(object sender, EventArgs e)
        {
            btnSelectPlayer.Enabled = false;
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            if (ctrlPlayerCardWithFilter1.SelectedPlayerInfo == null || !ctrlPlayerCardWithFilter1.SelectedPlayerInfo.PlayerID.HasValue)
                return;
            RaiseOnPlayerSelected
                (
                new OnPlayerSelectedEventArgs(
                ctrlPlayerCardWithFilter1.SelectedPlayerInfo.PlayerID.Value,
                ctrlPlayerCardWithFilter1.SelectedPlayerInfo)
                );
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
