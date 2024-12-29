using System;

namespace FortyFlavors.Core.Application.Queries.Payments;

public class GetUserPaymentsQuery
{
    public int UserId { get; }

    public GetUserPaymentsQuery(int userId)
    {
        UserId = userId;
    }
}
