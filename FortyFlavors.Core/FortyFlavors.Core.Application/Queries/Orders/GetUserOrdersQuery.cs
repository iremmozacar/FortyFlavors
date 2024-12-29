using System;

namespace FortyFlavors.Core.Application.Queries.Orders;

public class GetUserOrdersQuery
{
    public int UserId { get; }

    public GetUserOrdersQuery(int userId)
    {
        UserId = userId;
    }
}
