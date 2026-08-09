using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BilliardsDataAccessLayer;
using BilliardsDataAccessLayer.DTOs;
namespace BilliardsBusinessLayer
{
    public class clsPoolTableStatus
    {
        public clsPoolTable Table { get; private set; }
        public bool IsAvailable { get;  private set; }
        public int? CurrentPaymentID { get; private set; }
        public int? CurrentPlayerID { get;  set; }
        public string? CurrentPlayerName { get;  set; }
        public DateTime? StartTime { get; private set; }
       
        public clsPoolTableStatus(PoolTableStatusDTO dto)
        {
            Table = clsPoolTable.FromDTO(dto.Table);
            IsAvailable = dto.IsAvailable;
            CurrentPaymentID = dto.CurrentPaymentID;
            CurrentPlayerID = dto.CurrentPlayerID;
            CurrentPlayerName = dto.CurrentPlayerName;
            StartTime = dto.StartTime;
        }
        public static async Task<List<clsPoolTableStatus>> GetAllPoolTablesStatusAsync()
        {
            List<PoolTableStatusDTO> dtos = await clsPoolTablesData.GetAllPoolTablesStatusAsync();
           
            return dtos.Select(d => new clsPoolTableStatus(d)).ToList();
        }
        public async Task<int?> StartSessionAsync(clsPlayer Player, int CreatedByUserID)
        {

            if(!IsAvailable)
                throw new InvalidOperationException("Cannot start a session on an unavailable pool table.");

            if(!Player.PlayerID.HasValue)
                throw new InvalidOperationException("Selected player does not exist.");



            int? PaymentID = await clsPoolTablesData.StartSessionAsync(Table.TableID.Value, Player.PlayerID.Value, CreatedByUserID);

            if (PaymentID.HasValue)
            {
                IsAvailable = false;
                CurrentPaymentID = PaymentID;
                CurrentPlayerID = Player.PlayerID;
                CurrentPlayerName= Player.PersonInfo.FullName();
                StartTime = DateTime.Now;
            }
            return PaymentID;
        }
        public async Task<bool> EndSessionAsync()
        { 
            if (IsAvailable)
                throw new InvalidOperationException("Cannot End a session That is not started.");
            
            if (!CurrentPaymentID.HasValue)
                throw new InvalidOperationException("Current payment is missing.");

            if (!StartTime.HasValue)
                throw new InvalidOperationException("Session start time is missing.");
            
            
            decimal Fees =  (decimal)Table.CalculateFees(StartTime.Value,DateTime.Now);
               
            bool Result = await clsPoolTablesData.EndSessionAsync(CurrentPaymentID.Value, Fees);


            return Result;
        }
        public void ResetTable()
        {
            IsAvailable = true;
            CurrentPaymentID = null;
            CurrentPlayerID = null;
            CurrentPlayerName = null;
            StartTime = null;
        }
    }
}
