using System;

namespace FortyFlavors.Core.Application.Queries.Users;

public class SearchProductsQuery
{
    public string SearchTerm { get; }

    public SearchProductsQuery(string searchTerm)
    {
        SearchTerm = searchTerm;
    }
}
