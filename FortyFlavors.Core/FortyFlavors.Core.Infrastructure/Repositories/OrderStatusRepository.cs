using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class OrderStatusRepository : GenericRepository<OrderStatus>, IOrderStatusRepository
    {
        private readonly AppDbContext _context;

        public OrderStatusRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderStatus>> GetOrderStatusesByOrderIdAsync(int orderId)
        {
            return await _context.OrderStatuses
                .Where(os => os.OrderId == orderId)
                .OrderBy(os => os.UpdatedAt)
                .ToListAsync();
        }

        public async Task<OrderStatus> GetLatestOrderStatusAsync(int orderId)
        {
            return await _context.OrderStatuses
                .Where(os => os.OrderId == orderId)
                .OrderByDescending(os => os.UpdatedAt)
                .FirstOrDefaultAsync();
        }
    }
}