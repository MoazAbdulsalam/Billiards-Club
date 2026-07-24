using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
