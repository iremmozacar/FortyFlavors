using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    Task<IEnumerable<Order>> GetOrdersByStatusAsync(string status);
}
