using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class ComplateOrderCommand : IRequest<bool>
{
    public int OrderId { get; set; }

    void CompleteOrderCommand(int orderId)
    {
        OrderId = orderId;
    }
}
