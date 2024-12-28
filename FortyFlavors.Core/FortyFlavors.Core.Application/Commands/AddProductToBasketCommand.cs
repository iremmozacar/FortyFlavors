using System;
using System.Net;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class AddProductToBasketCommand : IRequest<bool>
{
    public int UserId { get; set; }      
    public int ProductId { get; set; }   
    public int Quantity { get; set; }    

    public AddProductToBasketCommand(int userId, int productId, int quantity)
    {
        UserId = userId;
        ProductId = productId;
        Quantity = quantity;
    }
}
