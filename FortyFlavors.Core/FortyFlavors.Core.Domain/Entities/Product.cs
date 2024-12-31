using System;

namespace FortyFlavors.Core.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public Guid BusinessId { get; private set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
    public Guid CategoryId { get; set; }

    public Business Business { get; set; }

    public ICollection<OrderItem>? OrderItems { get; set; }
    public ICollection<BasketItem>? BasketItems { get; set; }
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<Likes>? Likes { get; set; }

    public Product(string name, string description, decimal price, Guid businessId)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Ürün adı boş olamaz.");
        if (price <= 0)
            throw new ArgumentException("Ürün fiyatı sıfırdan büyük olmalıdır.");

        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        BusinessId = businessId;
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Yeni fiyat sıfırdan büyük olmalıdır.");
        Price = newPrice;
    }
}
