using FortyFlavors.Core.Application.Intefaces.Repository;

using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        private readonly AppDbContext _context;

        public ReviewRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Review>> GetReviewsByProductIdAsync(int productId)
        {
            return await _context.Reviews.Where(r => r.ProductId == productId).ToListAsync();
        }

        public async Task<double> GetAverageRatingByProductIdAsync(int productId)
        {
            return await _context.Reviews.Where(r => r.ProductId == productId).AverageAsync(r => r.Rating);
        }
    }
}