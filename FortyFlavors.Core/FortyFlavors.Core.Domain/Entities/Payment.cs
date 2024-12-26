using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Payment
{
    public Guid Id { get; private set; }
    public Guid OrderId { get; private set; }
    public DateTime PaymentDate { get; private set; }
    public decimal Amount { get; private set; }
    public string PaymentStatus { get; private set; }

    public Payment(Guid orderId, DateTime paymentDate, decimal amount, string paymentStatus)
    {
      
        if (string.IsNullOrWhiteSpace(paymentStatus))
            throw new ArgumentException("Ödeme durumu belirtilmelidir.");

        Id = Guid.NewGuid();
        OrderId = orderId;
        PaymentDate = paymentDate;
        Amount = amount;
        PaymentStatus = paymentStatus;
    }

    public void UpdateStatus(string newStatus)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
            throw new ArgumentException("Yeni ödeme durumu boş olamaz.");
        PaymentStatus = newStatus;
    }
}
