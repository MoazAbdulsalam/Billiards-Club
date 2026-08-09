using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using SharedUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilliardsDataAccessLayer
{
    public class clsPaymentsData
    {
        static PaymentDTO _FillPaymentData(SqlDataReader reader)
        {
            return new PaymentDTO
            {
                PaymentID = Convert.ToInt32(reader["PaymentID"]),
                PlayerID =Convert.ToInt32(reader["PlayerID"]),
                TableID = Convert.ToInt32(reader["TableID"]),
                StartTime = Convert.ToDateTime(reader["StartTime"]),
                EndTime = reader["EndTime"] == DBNull.Value ? null : Convert.ToDateTime(reader["EndTime"]),
                DateOfPayment = reader["DateOfPayment"] == DBNull.Value ? null : Convert.ToDateTime(reader["DateOfPayment"]),
                CreatedByUserID =Convert.ToInt32(reader["CreatedByUserID"]),
                Fees = reader["Fees"] == DBNull.Value ? null : Convert.ToDecimal(reader["Fees"])
            };
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
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
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
        public static async Task<PaymentDTO> GetPaymentByPaymentIDAsync(int PaymentID)
        {
            PaymentDTO? result = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetPaymentByPaymentID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                result = _FillPaymentData(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsPaymentsData → GetPaymentByPaymentIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return result;
        }
    }
}
//وفي الـ Business Layer بعد كده يكون عندك منطق مثل:

//إنشاء لاعب:
//تتأكد أن الـ Person موجود.
//تتأكد أنه ليس لاعبًا بالفعل (IsPersonPlayer).
//تعمل AddNewPlayer.
//عرض تفاصيل لاعب:
//GetPlayerInfoByID.
//تعمل Person = clsPerson.Find(PersonID).
//تعرض بيانات اللاعب + الشخص.

//بالنسبة للـ DTO، غالبًا تعمل:

//PlayerDTO فيه بيانات اللاعب فقط.
//وفي الـ Business Object clsPlayer يكون فيه:
//Person كـ object من clsPerson.

//الهيكل عندك كده ماشي صح:
//People → Users / Players → Payments
//والـ Players DAL هيكون طبقة الربط بين جدول اللاعبين وباقي النظام.
//كل حجوزات اليوم.
//كل الحجوزات لطاولة معينة.
//الحجوزات المفتوحة.