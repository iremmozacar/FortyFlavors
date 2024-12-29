using System;

namespace FortyFlavors.Core.Application.Queries.Orders;

public class GetOrdersByStatusQuery
{
    public string Status { get; }

    public GetOrdersByStatusQuery(string status)
    {
        Status = status;
    }
}
