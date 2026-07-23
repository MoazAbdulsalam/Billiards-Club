using System;
using System.Collections.Generic;
using System.Configuration;


namespace BilliardsDataAccessLayer
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
    }
}
