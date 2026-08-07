using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using BilliardsDataAccessLayer;
using BilliardsDataAccessLayer.DTOs;
namespace BilliardsBusinessLayer
{
    public class clsPlayer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; } = enMode.AddNew;
        public int? PlayerID { get; private set; }
        public int? PersonID { get;  set; }
        public clsPerson? PersonInfo { get; private set; }
        public DateTime DateOfJoin { get; set; }
        public int CreatedByUserID { get; set; }
        public PlayerStatisticsDTO? PlayerStatistics { get; private set; }
        public clsPlayer()
        {
            Mode = enMode.AddNew;
            PlayerID = null;
            PersonID = null;
            PersonInfo = null;
            DateOfJoin = DateTime.Now;
            CreatedByUserID = -1;

        }
        private clsPlayer(PlayerDTO Player)
        {
            this.PlayerID = Player.PlayerID;
            this.PersonID = Player.PersonID;
            this.DateOfJoin = Player.DateOfJoin;
            this.CreatedByUserID = Player.CreatedByUserID;
            Mode = enMode.Update;
        }
        public static async Task<clsPlayer?> FindByPlayerIDAsync(int PlayerID)
        {
            PlayerDTO? player = await clsPlayersData.GetPlayerInfoByIDAsync(PlayerID);

            if (player != null)
            {
                clsPlayer PlayerFound = new clsPlayer(player);
                PlayerFound.PersonInfo = await clsPerson.FindAsync(PlayerFound.PersonID.Value);
                PlayerFound.PlayerStatistics = await clsPlayersData.GetPlayerStatisticsAsync(PlayerID);

                return PlayerFound;
            }

            return null;
        }
        public static async Task<clsPlayer?> FindPlayerByPersonIDAsync(int PersonID)
        {
            PlayerDTO? player = await clsPlayersData.GetPlayerInfoByPersonIDAsync(PersonID);

            if (player != null)
            {
                clsPlayer PlayerFound = new clsPlayer(player);
                PlayerFound.PersonInfo = await clsPerson.FindAsync(PlayerFound.PersonID.Value);
                PlayerFound.PlayerStatistics = await clsPlayersData.GetPlayerStatisticsAsync(PlayerFound.PlayerID.Value);

                return PlayerFound;
            }

            return null;
        }
        private async Task<bool> _AddNewPlayerAsync()
        {
            if (PersonID == null)
            {
                throw new InvalidOperationException("Person must be set before adding a new player.");
            }
            if (await clsPlayersData.IsPersonPlayerAsync(PersonID.Value))
            {
                throw new InvalidOperationException("This person is already a player.");

            }
            PlayerID = await clsPlayersData.AddNewPlayerAsync(PersonID.Value, DateOfJoin, CreatedByUserID);

            if (!PlayerID.HasValue)
            {
                return false;
            }

            return true;
        }
        private Task<bool> _UpdatePlayerAsync()
        {
            if (!PlayerID.HasValue)
            {
                throw new InvalidOperationException("Player ID is missing.");
            }

            return clsPlayersData.UpdatePlayerAsync(PlayerID.Value, DateOfJoin);
        }
        public async Task<bool> SaveAsync()
        {


            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewPlayerAsync())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return await _UpdatePlayerAsync();

            }

            return false;
        }
        public  Task<bool> Delete()
        {
            if (PlayerID == null)
            {
                throw new InvalidOperationException("PlayerID is not set.");
            }
            return clsPlayersData.DeletePlayerAsync(PlayerID.Value);
        }
        public static Task<bool> DeleteAsync(int playerID)
        {
            if (playerID <= 0)
            {
                throw new InvalidOperationException("PlayerID is not set.");
            }
            return clsPlayersData.DeletePlayerAsync(playerID);

        }
        public static Task<DataTable?> GetAllPlayersAsync()
        {
            return clsPlayersData.GetAllPlayersAsync();
        }
        public static Task<bool> IsPersonPlayerAsync(int PersonID)
        {
            return clsPlayersData.IsPersonPlayerAsync(PersonID);
        }
        public static Task<DataTable?> GetPlayerPaymentsAsync(int PlayerID)
        {
            return clsPaymentsData.GetPlayerPaymentsAsync(PlayerID);
        }
        public Task<DataTable?> GetPlayerPaymentsAsync()
        {
            return clsPaymentsData.GetPlayerPaymentsAsync(PlayerID.Value);
        }
        public static Task<bool> IsPlayerExistsAsync(int PlayerID)
        {
            return clsPlayersData.IsPlayerExistAsync(PlayerID);
        }
        public async Task LoadStatisticsAsync()
        {
            if (!PlayerID.HasValue)
                throw new InvalidOperationException("Player ID is missing.");

            PlayerStatistics = await clsPlayersData.GetPlayerStatisticsAsync(PlayerID.Value);
        }
        public static Task<DataTable?> GetInactivePlayersAsync()
        {
            return clsPlayersData.GetInactivePlayersAsync();
        }
        public static Task<bool> RestorePlayerAsync(int PlayerID)
        {
            return clsPlayersData.RestorePlayerAsync(PlayerID);
        }
    }
}




