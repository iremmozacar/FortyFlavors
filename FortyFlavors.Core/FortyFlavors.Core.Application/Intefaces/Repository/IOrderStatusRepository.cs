using FortyFlavors.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Intefaces.Repository
{
    public interface IOrderStatusRepository : IGenericRepository<OrderStatus>
    {
        Task<IEnumerable<OrderStatus>> GetOrderStatusesByOrderIdAsync(int orderId);
        Task<OrderStatus> GetLatestOrderStatusAsync(int orderId);
    }
}