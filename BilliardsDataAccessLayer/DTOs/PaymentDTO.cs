using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class PaymentDTO
    {
        public int PaymentID { get; set; }
        public int PlayerID { get; set; }
        public int TableID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public int CreatedByUserID { get; set; }
        public decimal? Fees { get; set; }
    }
}
