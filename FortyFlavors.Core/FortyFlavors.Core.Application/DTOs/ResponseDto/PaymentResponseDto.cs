using System;

namespace FortyFlavors.Core.Application.DTOs
{
    public class PaymentResponseDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentStatus { get; set; }
        public int UserId { get; set; }

        public PaymentResponseDto() { }

        public PaymentResponseDto(int id, int orderId, DateTime paymentDate, decimal amount, string paymentStatus, int userId)
        {
            Id = id;
            OrderId = orderId;
            PaymentDate = paymentDate;
            Amount = amount;
            PaymentStatus = paymentStatus;
            UserId = userId;
        }
    }
}