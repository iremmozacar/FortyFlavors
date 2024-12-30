using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> SearchProducts(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}
