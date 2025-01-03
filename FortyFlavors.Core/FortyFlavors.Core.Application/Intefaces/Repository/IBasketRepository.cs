using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IBasketRepository : IGenericRepository<Basket>
{
    Task<Basket> GetBasketWithItemsAsync(int userId);
}