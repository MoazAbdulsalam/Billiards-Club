using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class PoolTableDTO
    {
        public int TableID { get; set; }
        public int TableNumber { get; set; }
        public decimal PaymentPerHour { get; set; }
    }

    public class PoolTableStatusDTO
    {
        public PoolTableDTO Table { get; set; }

        public bool IsAvailable { get; set; }

        public int? CurrentPaymentID { get; set; }
        public int? CurrentPlayerID { get; set; }
        public string? CurrentPlayerName { get; set; }
        public DateTime? StartTime { get; set; }
    }
}
