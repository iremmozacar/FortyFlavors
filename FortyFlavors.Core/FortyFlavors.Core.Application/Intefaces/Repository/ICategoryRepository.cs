using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<Category> GetCategoryWithProductsAsync(int categoryId);
}
