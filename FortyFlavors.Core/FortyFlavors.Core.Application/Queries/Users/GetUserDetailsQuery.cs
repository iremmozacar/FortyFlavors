using System;

namespace FortyFlavors.Core.Application.Queries.Users;

public class GetUserDetailsQuery
{
    public int UserId { get; }

    public GetUserDetailsQuery(int userId)
    {
        UserId = userId;
    }
}
