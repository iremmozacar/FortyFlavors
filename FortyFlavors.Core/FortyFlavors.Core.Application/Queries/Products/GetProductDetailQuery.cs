using System;

namespace FortyFlavors.Core.Application.Queries.Products;

public class GetProductDetailQuery
{
    public int ProductId { get; }

    public GetProductDetailQuery(int productId)
    {
        ProductId = productId;
    }
}
