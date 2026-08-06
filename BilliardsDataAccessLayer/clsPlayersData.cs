using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using SharedUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilliardsDataAccessLayer
{
    public class clsPlayersData
    {
        private static PlayerDTO _FillPlayerData(SqlDataReader reader)
        {
            return new PlayerDTO
            {
                PlayerID = (int)reader["PlayerID"],
                PersonID = (int)reader["PersonID"],
                DateOfJoin = (DateTime)reader["DateOfJoin"],
                CreatedByUserID = (int)reader["CreatedByUserID"]
            };
        }
        public static async Task<PlayerDTO?> GetPlayerInfoByIDAsync(int PlayerID)
        {
            PlayerDTO? PlayerInfo = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPlayerInfoByID", conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                PlayerInfo = _FillPlayerData(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → GetPlayerInfoByIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }

                }
            }
            return PlayerInfo;

        }
        public static async Task<PlayerDTO?> GetPlayerInfoByPersonIDAsync(int PersonID)
        {
            PlayerDTO? PlayerInfo = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPlayerInfoByPersonID", conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                PlayerInfo = _FillPlayerData(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → GetPlayerInfoByPersonIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }

                }
            }
            return PlayerInfo;

        }
        public static async Task<int?> AddNewPlayerAsync(int PersonID, DateTime DateOfJoin, int CreatedByUserID)
        {
            int? NewPlayerID = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewPlayer", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@DateOfJoin", DateOfJoin);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    SqlParameter OutputID = new SqlParameter("@NewPlayerID", System.Data.SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(OutputID);
                    try
                    {
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        if (OutputID.Value != DBNull.Value)
                        {
                            NewPlayerID = (int)OutputID.Value;
                        }

                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → AddNewPlayerAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return NewPlayerID;
        }
        public static async Task<bool> DeletePlayerAsync(int PlayerID)
        {
            bool IsDeleted = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_DeletePlayer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                    try
                    {
                        await conn.OpenAsync();
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        IsDeleted = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → DeletePlayerAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return IsDeleted;
        }
        public static async Task<DataTable?> GetAllPlayersAsync()
        {
            DataTable? dt = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPlayers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows )
                            {
                                dt = new DataTable();
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → GetAllPlayersAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                        
                    }
                }
            }
            return dt;
        }
        public static async Task<bool> IsPlayerExistAsync(int PlayerID)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsPlayerExist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                    SqlParameter returnedValue = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnedValue);
                    try
                    {
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        if (returnedValue.Value != DBNull.Value)
                        {
                            found = Convert.ToInt32(returnedValue.Value) == 1;
                        }

                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → IsPlayerExistAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return found;
        }
        public static async Task<bool> IsPersonPlayerAsync(int PersonID)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsPersonPlayer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    SqlParameter returnedValue = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(returnedValue);
                    try
                    {
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        if (returnedValue.Value != DBNull.Value)
                        {
                            found = Convert.ToInt32(returnedValue.Value) == 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → IsPersonPlayerAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return found;
        }
        public static async Task<DataTable?> GetPlayerPaymentsAsync(int PlayerID)
        {
            DataTable? dt = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPlayerPayments", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlayerID", PlayerID);
                    try
                    {
                        await conn.OpenAsync();
                        using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.HasRows) 
                            {
                                dt = new DataTable();
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPlayersData → GetPlayerPaymentsAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return dt;
        }
    }
}








