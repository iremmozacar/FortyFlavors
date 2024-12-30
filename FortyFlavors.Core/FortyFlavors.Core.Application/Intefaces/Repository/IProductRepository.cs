using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IProductRepository
{
    void AddProduct(Product product);
    Product GetProductById(int productId);
    IEnumerable<Product> GetProductsByCategoryId(int categoryId); 
    IEnumerable<Product> SearchProducts(string searchTerm);
    IEnumerable<Product> GetAllProducts(); 
    void UpdateProduct(Product product);
    void DeleteProduct(int productId);
}
