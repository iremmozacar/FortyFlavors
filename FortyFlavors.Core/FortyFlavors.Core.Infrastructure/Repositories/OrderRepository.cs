using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using FortyFlavors.Core.Infrastructure;
using FortyFlavors.Core.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    private readonly AppDbContext _context;

    public OrderRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
    {
        return await _context.Orders.Where(o => o.UserId == userId).ToListAsync();
    }

    public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(string status)
    {
        return await _context.Orders.Where(o => o.Status == status).ToListAsync();
    }
}