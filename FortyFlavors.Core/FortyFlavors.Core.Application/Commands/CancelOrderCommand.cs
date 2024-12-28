using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class CancelOrderCommand:IRequest<bool>
{
    public int OrderId { get; set; }

    public CancelOrderCommand(int orderId)
    {
        OrderId = orderId;
    }
}
