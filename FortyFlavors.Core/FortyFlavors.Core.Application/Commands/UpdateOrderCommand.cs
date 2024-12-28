using System;
using MediatR;
namespace FortyFlavors.Core.Application.Commands;

public class UpdateOrderCommand : IRequest<bool>
{
    public int OrderId { get; set; }
    public List<int> UpdatedProductIds { get; set; }
    public decimal UpdatedTotalAmount { get; set; }

    public UpdateOrderCommand(int orderId, List<int> updatedProductIds, decimal updatedTotalAmount)
    {
        OrderId = orderId;
        UpdatedProductIds = updatedProductIds;
        UpdatedTotalAmount = updatedTotalAmount;
    }
}
