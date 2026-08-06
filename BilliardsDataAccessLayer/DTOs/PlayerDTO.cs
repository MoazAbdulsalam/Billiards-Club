using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class PlayerDTO
    {
        public int PlayerID { get; set; }
        public int PersonID { get; set; }
        public DateTime DateOfJoin { get; set; }
        public int CreatedByUserID { get; set; }
    }
}
