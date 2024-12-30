using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public decimal TotalAmount { get; private set; }

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public User User { get; set; }

    public Order(Guid userId, DateTime orderDate, decimal totalAmount)
    {
        if (totalAmount <= 0)
            throw new ArgumentException("Toplam tutar sıfırdan büyük olmalıdır.");

        Id = Guid.NewGuid();
        UserId = userId;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
    }

    public void UpdateTotalAmount(decimal newTotalAmount)
    {
        if (newTotalAmount <= 0)
            throw new ArgumentException("Yeni toplam tutar sıfırdan büyük olmalıdır.");
        TotalAmount = newTotalAmount;
    }
}
