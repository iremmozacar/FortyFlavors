using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class UpdateBasketCommand : IRequest<bool>
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int UpdatedQuantity { get; set; }

    public UpdateBasketCommand(int userId, int productId, int updatedQuantity)
    {
        UserId = userId;
        ProductId = productId;
        UpdatedQuantity = updatedQuantity;
    }
}
