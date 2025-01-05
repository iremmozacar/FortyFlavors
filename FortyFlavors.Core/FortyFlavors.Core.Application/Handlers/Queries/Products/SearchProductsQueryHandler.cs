using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Intefaces.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class SearchProductsQuery : IRequest<List<ProductDto>>
{
    public string SearchTerm { get; set; }

    public SearchProductsQuery(string searchTerm)
    {
        SearchTerm = searchTerm;
    }
}

public class SearchProductsQueryHandler : IRequestHandler<SearchProductsQuery, List<ProductDto>>
{
    private readonly IAppDbContext _context;

    public SearchProductsQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ProductDto>> Handle(SearchProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _context.Products
            .Where(p => p.Name.Contains(request.SearchTerm) || p.Description.Contains(request.SearchTerm))
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            })
            .ToListAsync(cancellationToken);

        return products;
    }
}