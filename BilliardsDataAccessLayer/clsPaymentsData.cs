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