
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class BasketRepository : GenericRepository<Basket>, IBasketRepository
    {
        private readonly AppDbContext _context;

        public BasketRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Basket> GetBasketByUserIdAsync(int userId)
        {
            return await _context.Baskets.Include(b => b.BasketItems).FirstOrDefaultAsync(b => b.UserId == userId);
        }

        public async Task<Basket> GetBasketWithItemsAsync(int userId)
        {
            return await _context.Baskets
                .Include(b => b.BasketItems)
                .ThenInclude(bi => bi.Product)
                .FirstOrDefaultAsync(b => b.UserId == userId);
        }
    }
}