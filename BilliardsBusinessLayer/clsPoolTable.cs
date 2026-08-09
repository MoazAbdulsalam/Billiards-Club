using BilliardsDataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using BilliardsDataAccessLayer;
using System.Data;
namespace BilliardsBusinessLayer
{
    public class clsPoolTable
    {
        public int? TableID { get; private set; }
        public int? TableNumber { get; set; }
        public decimal PaymentPerHour { get; set; }
        public enum enMode { AddNew,Update}
        public enMode Mode { get; private set; }
        public clsPoolTable()
        {
            TableID = null;
            TableNumber = null;
            PaymentPerHour = 0.0m;
            Mode = enMode.AddNew;
        }
        private clsPoolTable(PoolTableDTO dto)
        {
            TableID = dto.TableID;
            TableNumber = dto.TableNumber;
            PaymentPerHour = dto.PaymentPerHour;
            Mode = enMode.Update;
        }
        public static clsPoolTable FromDTO(PoolTableDTO dto)
        {
            return new clsPoolTable(dto);
        }
        public static async Task<clsPoolTable?> FindByTableIDAsync(int TableID)
        {
            PoolTableDTO? dto = await clsPoolTablesData.GetPoolTableByIDAsync(TableID);
            if (dto != null)
            {
                clsPoolTable tableFound = new clsPoolTable(dto);
                return tableFound;
            }
            return null;
        }
        
        async Task<bool> _AddNewTableAsync()
        {
            PoolTableDTO dto = new PoolTableDTO
            {
                TableNumber = this.TableNumber.HasValue ? this.TableNumber.Value : 0,
                PaymentPerHour = this.PaymentPerHour
            };
            int? newID = await clsPoolTablesData.AddNewPoolTableAsync(dto);
            if (newID != null)
            {
                this.TableID = newID;
            }
            return this.TableID.HasValue;
        }
        Task<bool> _UpdateTable()
        {
            if (!this.TableID.HasValue)
                throw new InvalidOperationException("Cannot update a pool table without a valid TableID.");
            PoolTableDTO dto = new PoolTableDTO
            {
                TableID = this.TableID.Value,
                TableNumber = this.TableNumber.HasValue ? this.TableNumber.Value : 0,
                PaymentPerHour = this.PaymentPerHour
            };
            return clsPoolTablesData.UpdatePoolTableAsync(dto);
        }
        public async Task<bool> SaveAsync()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewTableAsync())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return await _UpdateTable();

            }

            return false;
        }
        public static Task<DataTable> GetAllPoolTablesAsync()
        {
            return clsPoolTablesData.GetAllPoolTablesAsync();
        }
        public double CalculateFees(DateTime startTime, DateTime endTime)
        {
            TimeSpan duration = endTime - startTime;
            double hours = duration.TotalHours;
            return hours * (double)PaymentPerHour;
        }
    }
}
