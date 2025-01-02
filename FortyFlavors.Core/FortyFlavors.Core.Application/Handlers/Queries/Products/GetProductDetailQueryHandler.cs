using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Interfaces;

namespace FortyFlavors.Core.Application.Handlers.Queries
{
    public class GetProductDetailQuery : IRequest<ProductDto>
    {
        public int ProductId { get; set; }

        public GetProductDetailQuery(int productId)
        {
            ProductId = productId;
        }
    }

    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDto>
    {
        private readonly IAppDbContext _context;

        public GetProductDetailQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<ProductDto> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(p => p.Id == request.ProductId)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (product == null)
                throw new KeyNotFoundException("Product not found");

            return product;
        }
    }
}