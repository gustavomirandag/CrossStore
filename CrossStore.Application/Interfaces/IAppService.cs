using CrossStore.Application.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Application.Interfaces
{
    public interface IAppService
    {
        bool AddProduct(ProductViewModel productViewModel);

        IEnumerable<ProductViewModel> GetAllProducts();

        void UpdateProduct(ProductViewModel productViewModel);

        void DeleteProduct(Guid productId);
    }
}
