using CrossStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);

        IEnumerable<Product> GetAllProducts();

        void UpdateProduct(Product product);

        void DeleteProduct(Guid productId);
    }
}
