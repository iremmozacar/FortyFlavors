using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IPaymentRepository : IGenericRepository<Payment>
{
    Task<Payment> GetPaymentByOrderIdAsync(int orderId);
    Task<IEnumerable<Payment>> GetPaymentsByUserIdAsync(int userId);
}
