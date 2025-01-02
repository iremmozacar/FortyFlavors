using System;
using System.Collections.Generic;

namespace FortyFlavors.Core.Domain.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; private set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public User User { get; set; }

        public Order() { }


        public Order(int userId, DateTime orderDate, decimal totalAmount)
        {
            if (totalAmount <= 0)
                throw new ArgumentException("Toplam tutar sıfırdan büyük olmalıdır.");

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
}