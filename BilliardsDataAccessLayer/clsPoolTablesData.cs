using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using SharedUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilliardsDataAccessLayer
{

    public class clsPoolTablesData
    {
        private static PoolTableDTO _FillPoolTableData(SqlDataReader reader)
        {
            return new PoolTableDTO
            {
                TableID = (int)reader["TableID"],
                TableNumber = (int)reader["TableNumber"],
                PaymentPerHour = (decimal)reader["PaymentPerHour"]
            };
        }
        private static PoolTableStatusDTO _FillPoolTableStatusData(SqlDataReader reader)
        {
            return new PoolTableStatusDTO
            {
                Table = _FillPoolTableData(reader),
                IsAvailable = (bool)reader["IsAvailable"],
                CurrentPaymentID = reader["CurrentPaymentID"] == DBNull.Value ? null : (int)reader["CurrentPaymentID"],
                CurrentPlayerID = reader["CurrentPlayerID"] == DBNull.Value ? null : (int)reader["CurrentPlayerID"],
                CurrentPlayerName = reader["CurrentPlayerName"] == DBNull.Value ? null : reader["CurrentPlayerName"].ToString(),
                StartTime = reader["StartTime"] == DBNull.Value ? null : (DateTime)reader["StartTime"]
            };
        }

        public async static Task<DataTable> GetAllPoolTablesAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPoolTables", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → GetAllPoolTablesAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }

                }
            }
            return dt;
        }
        public async static Task<PoolTableDTO?> GetPoolTableByIDAsync(int tableID)
        {
            PoolTableDTO? result = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPoolTableByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableID", tableID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                result = _FillPoolTableData(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → GetPoolTableByIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return result;
        }
        public async static Task<int?> AddNewPoolTableAsync(PoolTableDTO newTable)
        {
            int? id = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AddNewPoolTable", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableNumber", newTable.TableNumber);
                    cmd.Parameters.AddWithValue("@PaymentPerHour", newTable.PaymentPerHour);
                    SqlParameter outputIdParam = new SqlParameter("@NewTableID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);
                    try
                    {
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        if (outputIdParam.Value != DBNull.Value)
                        {
                            id = (int)outputIdParam.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → AddNewPoolTableAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return id;
        }
        public async static Task<bool> UpdatePoolTableAsync(PoolTableDTO updatedTable)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_UpdatePoolTable", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableID", updatedTable.TableID);
                    cmd.Parameters.AddWithValue("@TableNumber", updatedTable.TableNumber);
                    cmd.Parameters.AddWithValue("@PaymentPerHour", updatedTable.PaymentPerHour);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await cmd.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → UpdatePoolTableAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return rowsAffected > 0;
        }

        public async static Task<List<PoolTableStatusDTO>> GetAllPoolTablesStatusAsync()
        {
            List<PoolTableStatusDTO> result = new List<PoolTableStatusDTO>();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPoolTablesStatus", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                PoolTableStatusDTO status = _FillPoolTableStatusData(reader);
                                result.Add(status);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → GetAllPoolTablesStatusAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }

                }
            }
            return result;

        }
        public async static Task<int?> StartSessionAsync(int tableID, int playerID,int CreatedByUserID)
        {
            int? paymentID = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_StartSession", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TableID", tableID);
                    cmd.Parameters.AddWithValue("@PlayerID", playerID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    SqlParameter outputIdParam = new SqlParameter("@NewPaymentID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);
                    try
                    {
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                        if (outputIdParam.Value != DBNull.Value)
                        {
                            paymentID = (int)outputIdParam.Value;
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPoolTablesData → StartSessionAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }

                }
            }
            return paymentID;
        }
        public async static Task<bool> EndSessionAsync(int paymentID, decimal Fees)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EndSession", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                    cmd.Parameters.AddWithValue("@Fees", Fees);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await cmd.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPoolTablesData → EndSessionAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }
            }
            return rowsAffected > 0;
        }

    }
}


 

//والـ Business:

//public static List<PoolTableStatus> GetAllPoolTablesStatus()
//{
//    List<PoolTableStatusDTO> dtos =
//        PoolTableDataAccess.GetAllPoolTablesStatus();

//    List<PoolTableStatus> result = new List<PoolTableStatus>();

//    foreach (PoolTableStatusDTO dto in dtos)
//    {
//        PoolTableStatus status = new PoolTableStatus
//        {
//            Table = new PoolTable
//            {
//                TableID = dto.Table.TableID,
//                TableNumber = dto.Table.TableNumber,
//                PaymentPerHour = dto.Table.PaymentPerHour
//            },

//            IsAvailable = dto.IsAvailable,
//            CurrentPaymentID = dto.CurrentPaymentID,
//            CurrentPlayerID = dto.CurrentPlayerID,
//            CurrentPlayerName = dto.CurrentPlayerName,
//            StartTime = dto.StartTime
//        };

//        result.Add(status);
//    }

//    return result;
//}

//فيبقى الـ Flow:

//SQL
// ↓
//Data Access
// ↓
//List<PoolTableStatusDTO>
// ↓
//Business Mapping
// ↓
//List<PoolTableStatus>
// ↓
//Form
// ↓
//PoolTableControl

//وبالتالي كل Control ياخد PoolTableStatus واحد:

//);
//}
// */