using System;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IProductService : IService<Product>
{
    Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId);
}