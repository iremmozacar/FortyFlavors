using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Payment
{
    public int Id { get; private set; }
    public int OrderId { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public decimal Amount { get; private set; }
    public string PaymentStatus { get; private set; }
    public int UserId { get; set; }
    public string PaymentMethod { get; private set; }
    public Order Order { get; set; }
    public Payment(int orderId, DateTime paymentDate, decimal amount, string paymentStatus, int userId)
    {
        if (string.IsNullOrWhiteSpace(paymentStatus))
            throw new ArgumentException("Ödeme durumu belirtilmelidir.");

        Id = Id;
        OrderId = orderId;
        PaymentDate = paymentDate;
        Amount = amount;
        PaymentStatus = paymentStatus;
        UserId = userId;
    }

    public void UpdateStatus(string newStatus)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
            throw new ArgumentException("Yeni ödeme durumu boş olamaz.");
        PaymentStatus = newStatus;
    }
}