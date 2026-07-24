using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using Shared;
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
                string query = "SELECT * FROM Users WHERE UserID=@UserID ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = "SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                string query = @"INSERT INTO Users
                           (PersonID
                           ,UserName
                           ,Password
                           ,IsActive)
                     VALUES
                      (@PersonID,@UserName,@Password,@IsActive) 
                      SELECT SCOPE_IDENTITY()";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", User.PersonID);
                    command.Parameters.AddWithValue("@UserName", User.UserName);
                    command.Parameters.AddWithValue("@Password", User.Password);
                    command.Parameters.AddWithValue("@IsActive", User.IsActive);
                    try
                    {
                        await connection.OpenAsync();
                        object? result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            id = insertedID;
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



                string query = @"UPDATE Users
                              SET PersonID = @PersonID, 
                                 UserName = @UserName,
                                 
                                 IsActive = @IsActive
                            WHERE UserID =@UserID ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {


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


                string query = @"SELECT Users.UserID, Users.PersonID, FullName =People.FirstName +' '+ People.SecondName+' '+ ISNULL( People.ThirdName,'')+' '+ People.LastName, Users.UserName, Users.IsActive
                           FROM     People INNER JOIN
                            Users ON People.PersonID = Users.PersonID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
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


                string query = "DELETE Users WHERE userID=@userID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {


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
                string query = "Select found=1 from Users WHERE UserID=@UserID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                       await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            found = reader.HasRows;
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
                string query = "Select found=1 from Users WHERE UserName=@UserName";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync()) 
                            found = reader.HasRows;
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

                string query = "Select found=1 from Users WHERE PersonID=@PersonID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {


                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            found = reader.HasRows;
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


                string query = @"UPDATE Users
                              SET  
                                 Password = @NewPassword
                            WHERE UserID =@UserID ;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {


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
