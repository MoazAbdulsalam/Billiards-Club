using BilliardsDataAccessLayer.DTOs;
using Microsoft.Data.SqlClient;
using Shared;
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
                string query = "SELECT * FROM People WHERE PersonID = @PersonID ;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
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
                string query = "SELECT * FROM People WHERE NationalNo = @NationalNo ;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
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
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gender,Address,Phone,Email,ImagePath)
                          VALUES (@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gender,@Address,@Phone,@Email,@ImagePath);
                          SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {  
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    if (!string.IsNullOrEmpty(ThirdName))
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    try
                    {
                        await connection.OpenAsync();
                        object result = await command.ExecuteScalarAsync();
                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            PersonID = InsertedID;
                        }

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
                string query = @"UPDATE People
                              SET NationalNo = @NationalNo, 
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName, 
                                 LastName = @LastName, 
                                 DateOfBirth = @DateOfBirth, 
                                 Gender = @Gender,
                                 Address = @Address, 
                                 Phone = @Phone, 
                                 Email = @Email, 
                                 ImagePath = @ImagePath
                            WHERE PersonID =@PersonID ;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    if (!string.IsNullOrEmpty(ThirdName))
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (!string.IsNullOrEmpty(Email))
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected =await command.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → UpdatePerson";
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
                string query = @" SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.DateOfBirth, 
	                   People.Gender,
	                   CASE
	                   When People.Gender=0 THEN 'Male'
	                   ELSE 'Female'
	                   End as GenderCaption,
	                   People.Address, People.Phone, People.Email, People.ImagePath
                       FROM  People ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
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

                        string Location = "clsPeopleData → GetAllPeople";
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
                string query = "DELETE People WHERE PersonID=@PersonID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();

                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → DeletePeron";
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

                string query = "Select found=1 from People WHERE NationalNo=@NationalNo";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            found = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → IsPersonExist(nationalNo)";
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

                string query = "Select found=1 from People WHERE PersonId=@PersonID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonId);
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            found = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {

                        string Location = "clsPeopleData → IsPersonExist(PersonID)";
                        clsEventLogger.LogEvent(ex, Location, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                }

            }
            return found;
        }


    }

}
