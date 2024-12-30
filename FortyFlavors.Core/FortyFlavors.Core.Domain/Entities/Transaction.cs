using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Transaction
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public decimal Amount { get; private set; }
    public string TransactionType { get; private set; }
    public DateTime TransactionDate { get; private set; }
    public string ReferenceNumber { get; private set; }
    public string TrackingNumber { get; private set; }

    public Transaction(Guid userId, decimal amount, string transactionType, DateTime transactionDate, string referenceNumber, string trackingNumber)
    {
        if (amount <= 0)
            throw new ArgumentException("İşlem tutarı sıfırdan büyük olmalıdır.");
        if (string.IsNullOrWhiteSpace(transactionType))
            throw new ArgumentException("İşlem türü belirtilmelidir.");
        if (string.IsNullOrWhiteSpace(referenceNumber))
            throw new ArgumentException("Referans numarası belirtilmelidir.");
        if (string.IsNullOrWhiteSpace(trackingNumber))
            throw new ArgumentException("Takip numarası belirtilmelidir.");

        Id = Guid.NewGuid();
        UserId = userId;
        Amount = amount;
        TransactionType = transactionType;
        TransactionDate = transactionDate;
        ReferenceNumber = referenceNumber;
        TrackingNumber = trackingNumber;
    }
}
