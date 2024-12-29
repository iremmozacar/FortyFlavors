using System;

namespace FortyFlavors.Core.Application.Queries.Users;

public class GetProductsByCategoryQuery
{
    public int CategoryId { get; }

    public GetProductsByCategoryQuery(int categoryId)
    {
        CategoryId = categoryId;
    }
}
