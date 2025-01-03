using System;
using System.Collections.Generic;

namespace FortyFlavors.Core.Domain.Entities
{
    public class Basket
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public ICollection<BasketItem> BasketItems { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Basket(int userId, int productId, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Ürün miktarı sıfırdan büyük olmalıdır.");

            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
                throw new ArgumentException("Yeni miktar sıfırdan büyük olmalıdır.");
            Quantity = newQuantity;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}