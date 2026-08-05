using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using SharedUtils;
using System.Data;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
namespace BilliardsDataAccessLayer
{
    public class clsPeopleData
    {
        private static clsPersonDTO FillPersonDTO(SqlDataReader Reader)
        {
            return new clsPersonDTO
                        {
                            PersonID = (int)Reader["PersonID"],
                            NationalNo = Reader["NationalNo"].ToString(),
                            FirstName = Reader["FirstName"].ToString(),
                            SecondName = Reader["SecondName"].ToString(),
                            ThirdName = Reader["ThirdName"] == DBNull.Value ? null : Reader["ThirdName"].ToString(),
                            LastName = Reader["LastName"].ToString(),

                            DateOfBirth = (DateTime)Reader["DateOfBirth"],
                            Gender = Convert.ToByte(Reader["Gender"]),
                            Address = Reader["Address"].ToString(),
                            Phone = Reader["Phone"].ToString(),
                            Email = Reader["Email"] == DBNull.Value ? null : Reader["Email"].ToString(),

                            ImagePath = Reader["ImagePath"] == DBNull.Value ? null : Reader["ImagePath"].ToString()
                        };
            }
        public static async Task<clsPersonDTO?> GetPersonInfoByIdAsync(int PersonID)
        {
            clsPersonDTO Person = null;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonInfoById", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader Reader =await command.ExecuteReaderAsync())
                        {
                            if (await Reader.ReadAsync())
                            {
                                Person=  FillPersonDTO(Reader);
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → GetPersonInfoById";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        
                    }
                }

            }
            return Person;
        }
        public static async Task<clsPersonDTO?> GetPersonInfoByNationalNoAsync( string NationalNo)
        {
            clsPersonDTO Person = null;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonInfoByNationalNo", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader Reader = await command.ExecuteReaderAsync())
                        {
                            if (await Reader.ReadAsync())
                            {
                                Person =  FillPersonDTO(Reader);
                            }

                        }
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → GetPersonInfoByNationalNo";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return Person;
        }
        public static async Task<int?> AddNewPersonAsync(string NationalNo,
            string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gender,
            string Address, string Phone, string Email,string ImagePath)
        {
            int? PersonID = null;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@ThirdName",
                        string.IsNullOrEmpty(ThirdName) ? DBNull.Value : ThirdName);

                    command.Parameters.AddWithValue("@Email",
                        string.IsNullOrEmpty(Email) ? DBNull.Value : Email);

                    command.Parameters.AddWithValue("@ImagePath",
                        string.IsNullOrEmpty(ImagePath) ? DBNull.Value : ImagePath);
                   
                    SqlParameter outputParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);
                   
                    try
                    {
                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                        if (outputParam.Value != DBNull.Value)
                            PersonID = Convert.ToInt32(outputParam.Value);
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → AddnewPerson";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
            }
            return PersonID;
        }
        public static async Task<bool> UpdatePersonAsync(int PersonID, string NationalNo,
         string FirstName, string SecondName, string ThirdName,
         string LastName, DateTime DateOfBirth, byte Gender,
         string Address, string Phone, string Email, string ImagePath)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdatePerson", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    command.Parameters.AddWithValue("@ThirdName",
                        string.IsNullOrEmpty(ThirdName) ? DBNull.Value : ThirdName);

                    command.Parameters.AddWithValue("@Email",
                        string.IsNullOrEmpty(Email) ? DBNull.Value : Email);

                    command.Parameters.AddWithValue("@ImagePath",
                        string.IsNullOrEmpty(ImagePath) ? DBNull.Value : ImagePath);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected =await command.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → UpdatePersonAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;

                    }
                    
                }
            }

            return rowsAffected > 0;

        }
        public static async Task<DataTable> GetAllPeopleAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {

                           dt.Load(reader);
                        }                        

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → GetAllPeopleAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                    }

                }
            }
            return dt;

        }
        public static async Task<bool> DeletePersonAsync(int PersonID)
        {
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePerson", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → DeletePersonAsync";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }
            }
            return rowsAffected > 0;

        }
        public static async Task<bool> IsPersonExistAsync(string NationalNo)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByNationalNo", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);
                    try
                    {
                        await conn.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                        found = (int)returnParameter.Value == 1;
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → IsPersonExistAsync(NationalNo)";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }

            }
            return found;
        }
        public static async Task<bool> IsPersonExistAsync(int PersonId)
        {
            bool found = false;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExistsByPersonID", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonId);

                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(returnParameter);
                    try
                    {
                        await conn.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                        found = Convert.ToInt32(returnParameter.Value) == 1;
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → IsPersonExistAsync(PersonID)";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }

            }
            return found;
        }


    }

}
