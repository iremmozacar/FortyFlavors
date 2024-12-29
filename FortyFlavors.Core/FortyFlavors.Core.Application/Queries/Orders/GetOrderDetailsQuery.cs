using System;

namespace FortyFlavors.Core.Application.Queries.Orders;

public class GetOrderDetailsQuery
{
    public int OrderId { get; }

    public GetOrderDetailsQuery(int orderId)
    {
        OrderId = orderId;
    }
}
