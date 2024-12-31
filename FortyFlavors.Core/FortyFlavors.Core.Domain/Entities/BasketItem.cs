using System;

namespace FortyFlavors.Core.Domain.Entities;

public class BasketItem
{
    public Guid Id { get; set; }
    public Guid BasketId { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;

    public Basket Basket { get; set; }
    public Product Product { get; set; }
}
