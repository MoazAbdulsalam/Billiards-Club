using BilliardsDataAccessLayer;
using BilliardsDataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilliardsBusinessLayer
{
    public class clsPayment
    {
        public int PaymentID { get; set; }
        public int PlayerID { get; set; }
        public int TableID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public int CreatedByUserID { get; set; }
        public decimal? Fees { get; set; }
        private clsPayment(PaymentDTO paymentDTO)
        {
            PaymentID = paymentDTO.PaymentID;
            PlayerID = paymentDTO.PlayerID;
            TableID = paymentDTO.TableID;
            StartTime = paymentDTO.StartTime;
            EndTime = paymentDTO.EndTime;
            DateOfPayment = paymentDTO.DateOfPayment;
            CreatedByUserID = paymentDTO.CreatedByUserID;
            Fees = paymentDTO.Fees;
        }
        public static async Task<clsPayment?> GetPaymentByPaymentIDAsync(int PaymentID)
        {
            PaymentDTO paymentDTO = await clsPaymentsData.GetPaymentByPaymentIDAsync(PaymentID);
            if (paymentDTO != null)
            {
                return new clsPayment(paymentDTO);
            }
            return null;
        }
    }
}
