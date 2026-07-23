using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class clsPersonDTO
    {
        public int PersonID { get; set; }

        public string NationalNo { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string? ThirdName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte Gender { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string? Email { get; set; }

        public string? ImagePath
        {
            get; set;
        }
  
    }
}
