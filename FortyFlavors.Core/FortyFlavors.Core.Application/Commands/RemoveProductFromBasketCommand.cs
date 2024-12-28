using System;
using MediatR;
namespace FortyFlavors.Core.Application.Commands;

public class RemoveProductFromBasketCommand : IRequest<bool>
{
    public int UserId { get; set; }
    public int ProductId { get; set; }

    public RemoveProductFromBasketCommand(int userId, int productId)
    {
        UserId = userId;
        ProductId = productId;
    }
}
