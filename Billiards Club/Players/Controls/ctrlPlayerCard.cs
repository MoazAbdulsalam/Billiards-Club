using Billiards_Club.Properties;
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
    public partial class ctrlPlayerCard : UserControl
    {
        clsPlayer _Player;
        int? _PlayerID = null;
        public int? PlayerID { get { return _PlayerID; } }
        public clsPlayer SelectedPlayerInfo { get { return _Player; } }
        
        public ctrlPlayerCard()
        {
            InitializeComponent();
        }

        private void _ResetPlayerInfo()
        {
            lblCreatedByUserID.Text = "???";
            lblDateOfJoin.Text = "???";
            lblFavoriteTable.Text = "???";
            lblPlayerID.Text = "???";
            lblTotalMoneyPaid.Text = "???";
            lblTotslHoursPlayed.Text = "???";
            _Player = null;
            _PlayerID = null;
            ctrlPersonCard1.Reset();
            
        }
        void _FillPlayerInfo()
        {
            _PlayerID = _Player.PlayerID;
            lblCreatedByUserID.Text = _Player.CreatedByUserID.ToString();
            lblDateOfJoin.Text = _Player.DateOfJoin.ToString("d");
            lblFavoriteTable.Text = _Player.PlayerStatistics?.MostPlayedTable.ToString() ?? "???";
            lblPlayerID.Text = _Player.PlayerID.ToString();
            lblTotalMoneyPaid.Text = _Player.PlayerStatistics?.TotalMoneyPaid.ToString("C") ?? "???";
            lblTotslHoursPlayed.Text = _Player.PlayerStatistics?.TotalHoursPlayed.ToString("0.##") ?? "???";
        }
        public async Task LoadPlayerInfoAsync(int ID, Enums.eFindBy findBy)
        {
            string ErrorMessage = "";
            switch (findBy)
            {
                case Enums.eFindBy.PlayerID:
                    _Player = await clsPlayer.FindByPlayerIDAsync(ID);
                    ErrorMessage = "No Player With PlayerID =" + ID.ToString();
                    break;
                case Enums.eFindBy.PersonID:
                    _Player = await clsPlayer.FindPlayerByPersonIDAsync(ID);
                    ErrorMessage = "No Player With PersonID =" + ID.ToString();
                    break;
            }
            if (_Player == null)
            {

                _ResetPlayerInfo();

                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
             await ctrlPersonCard1.LoadPersonAsync(_Player.PersonID.Value);
            
            _FillPlayerInfo();
        }

    }
}
