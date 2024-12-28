using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class RefundOrderCommand:IRequest<bool>
{
    public int OrderId { get; set; }
    public string Reason { get; set; }

    public RefundOrderCommand(int orderId, string reason)
    {
        OrderId = orderId;
        Reason = reason;
    }
}
