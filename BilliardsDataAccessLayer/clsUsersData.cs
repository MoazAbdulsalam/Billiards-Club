using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using SharedUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilliardsDataAccessLayer
{
    public class clsUsersData
    {
        private static UserDTO _FillUserData(SqlDataReader reader)
        {
            return new UserDTO
            {
                UserID = (int)reader["UserID"],
                PersonID = (int)reader["PersonID"],
                UserName = reader["UserName"].ToString(),
                Password = reader["Password"].ToString(),
                IsActive = (bool)reader["IsActive"]


            };
        }
        public static async Task<UserDTO?> GetUserInfoByUserIDAsync(int UserID)
        {
            UserDTO User = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserInfoByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                User = _FillUserData(reader);
                        }

                    }
                    catch (Exception ex)
                    {
                        string Location = "clsUsersData → GetUserInfoByIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
                return User;
            }
        }
        public static async Task<UserDTO?> GetUserInfoUserNameAndPasswordAsync(string UserName, string Password)
        {
            UserDTO User = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserInfoUserNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                                User = _FillUserData(reader);
                        }

                    }
                    catch (Exception ex)
                    {
                        string Location = "clsUsersData → GetUserInfoUserNameAndPasswordAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
                return User;
            }
        }
        public static async Task<int?> AddNewUserAsync(UserDTO User)
        {
            int? id = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", User.PersonID);
                    command.Parameters.AddWithValue("@UserName", User.UserName);
                    command.Parameters.AddWithValue("@Password", User.Password);
                    command.Parameters.AddWithValue("@IsActive", User.IsActive);
                    SqlParameter outputIdParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);
                    try
                    {
                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                        if(outputIdParam.Value != DBNull.Value)
                        {
                            id = (int)outputIdParam.Value;
                        }

                    }
                    catch (Exception ex)
                    {
                        string Location = "clsUsersData → AddNewUserAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
                return id;

            }

        }
        public static async Task<bool> UpdateUserAsync(UserDTO User)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUser", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", User.PersonID);
                    command.Parameters.AddWithValue("@UserName", User.UserName);
                    command.Parameters.AddWithValue("@IsActive", User.IsActive);
                    command.Parameters.AddWithValue("@UserID", User.UserID);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected =await command.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsUsersData → UpdateUserAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }

            }
            return rowsAffected > 0;
        }
        public static async Task<DataTable> GetAllUsersAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllUsers", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {


                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsUsersData → GetAllUsersAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }
                }

            }
            return dt;
        }
        public static async Task<bool> DeleteUserAsync(int userID)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {


                using (SqlCommand command = new SqlCommand("SP_DeleteUser", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsUsersData → DeleteUserAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }
            }
            return rowsAffected > 0;
        }
        public static async Task<bool> IsUserExistByUserIDAsync(int UserID)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsUserExistByUserID", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    SqlParameter outputFoundParam = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(outputFoundParam);
                    try
                    {
                       await conn.OpenAsync(); 
                       await command.ExecuteNonQueryAsync();

                        if (outputFoundParam.Value != DBNull.Value)
                            found = Convert.ToInt32(outputFoundParam.Value) == 1;
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsUsersData → IsUserExistByUserIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                }
            }
            return found;
        }
        public static async Task<bool> IsUserExistByUserNameAsync(string UserName)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsUserExistByUserName", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", UserName);
                    SqlParameter ReturnParameter = new SqlParameter(@"ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                     command.Parameters.Add(ReturnParameter);

                    try
                    {
                        await conn.OpenAsync();
                        await command.ExecuteNonQueryAsync();

                        if (ReturnParameter.Value != DBNull.Value)
                            found = Convert.ToInt32(ReturnParameter.Value) == 1;
                    }
                    catch (Exception ex)
                    {
                        string Location = "clsUsersData → IsUserExistByUserNameAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }
            }
            return found;
        }
        public static async Task<bool> IsUserExistForPersonIDAsync(int PersonID)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_IsUserExistForPersonID", conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    SqlParameter ReturnParameter = new SqlParameter(@"ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(ReturnParameter);
                    try
                    {
                        await conn.OpenAsync();
                        await command.ExecuteNonQueryAsync();

                        if (ReturnParameter.Value != DBNull.Value)
                            found = Convert.ToInt32(ReturnParameter.Value) == 1;
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsUsersData → IsUserExistForPersonIDAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }

                return found;
            }
        }
        public static async Task<bool> ChangePasswordAsync(int UserID, string NewPassword)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_ChangePassword", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NewPassword", NewPassword);
                    command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsUsersData → ChangePassword";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }

                }
            }
            return rowsAffected > 0;
        }

    }
}
