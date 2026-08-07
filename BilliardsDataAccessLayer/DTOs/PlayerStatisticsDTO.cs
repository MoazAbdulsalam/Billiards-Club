using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsDataAccessLayer.DTOs
{
    public class PlayerStatisticsDTO
    {
        public double TotalHoursPlayed { get; set; }
        public decimal TotalMoneyPaid { get; set; }
        public int? MostPlayedTable { get; set; }
    }

}
