using CrossStore.Domain.Entities;
using CrossStore.Domain.Interfaces.Repositories;
using CrossStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossStore.Domain.Services
{
    //Use Cases related to product
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public Product AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            repository.Create(product);
            repository.SaveChanges();
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return repository.ReadAll();
        }

        public void UpdateProduct(Product product)
        {
            repository.Update(product);
            repository.SaveChanges();
        }

        public void DeleteProduct(Guid productId)
        {
            repository.Delete(productId);
            repository.SaveChanges();
        }
    }
}
