using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    public void AddOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public void DeleteOrder(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public Order GetOrderById(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetOrdersByStatus(string status)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetOrdersByUserId(int userId)
    {
        throw new NotImplementedException();
    }

    public void UpdateOrder(Order order)
    {
        throw new NotImplementedException();
    }
}
