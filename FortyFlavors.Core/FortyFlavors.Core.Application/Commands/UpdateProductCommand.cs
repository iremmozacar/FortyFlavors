using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class UpdateProductCommand :IRequest<bool>
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public UpdateProductCommand(int productId, string name, string description, decimal price, int stock)
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
    }
}
