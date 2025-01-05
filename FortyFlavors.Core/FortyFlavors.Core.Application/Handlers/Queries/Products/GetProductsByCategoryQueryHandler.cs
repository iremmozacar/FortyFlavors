using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Intefaces.Common;


namespace FortyFlavors.Core.Application.Handlers.Queries
{
    public class GetProductsByCategoryQuery : IRequest<List<ProductDto>>
    {
        public int CategoryId { get; set; }

        public GetProductsByCategoryQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }

    public class GetProductsByCategoryQueryHandler : IRequestHandler<GetProductsByCategoryQuery, List<ProductDto>>
    {
        private readonly IAppDbContext _context;

        public GetProductsByCategoryQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> Handle(GetProductsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products
                .Where(p => p.CategoryId == request.CategoryId)
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
}