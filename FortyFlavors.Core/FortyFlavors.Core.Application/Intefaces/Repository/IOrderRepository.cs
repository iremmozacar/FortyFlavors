using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IOrderRepository
{
    void AddOrder(Order order);
    Order GetOrderById(int orderId);
    IEnumerable<Order> GetOrdersByUserId(int userId);
    void UpdateOrder(Order order);
    void DeleteOrder(int orderId);
}
