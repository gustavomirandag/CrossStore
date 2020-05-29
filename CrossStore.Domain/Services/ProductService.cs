using CrossStore.Domain.Entities;
using CrossStore.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrossStore.Domain.Services
{
    //Use Cases related to product
    public class ProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public void AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            repository.Create(product);
            repository.SaveChanges();
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
