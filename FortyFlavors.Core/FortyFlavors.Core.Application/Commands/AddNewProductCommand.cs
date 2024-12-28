using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class AddNewProductCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public AddNewProductCommand(string name, string description, decimal price, int stock)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
    }
}
