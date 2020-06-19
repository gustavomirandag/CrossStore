using CrossStore.Application.Models.ViewModels;
using CrossStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AutoMapper;
using CrossStore.Application.Interfaces;
using CrossStore.Domain.Entities;
using System.Linq;

namespace CrossStore.Application.Services
{
    public class CrossPlatformAppService : IAppService
    {
        public ObservableCollection<ProductViewModel> Products { get; set; }
        private IProductService productService;
        private Mapper mapper;

        public CrossPlatformAppService(IProductService productService)
        {
            this.productService = productService;
            Products = new ObservableCollection<ProductViewModel>();
            mapper = new Mapper(AutoMapper.AutoMapperConfig.RegisterMappings());
        }

        public bool AddProduct(ProductViewModel productViewModel)
        {
            //ViewModel -> Model
            var product = mapper.Map<Product>(productViewModel);
            product = productService.AddProduct(product);
            if (product == null)
                return false;

            //Model -> ViewModel
            productViewModel = mapper.Map<ProductViewModel>(product);
            Products.Add(productViewModel);

            return true;
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = productService.GetAllProducts();

            //Domain -> ViewModel
            return products.Select(p => mapper.Map<ProductViewModel>(p));
        }

        public void UpdateProduct(ProductViewModel productViewModel)
        {
            var product = mapper.Map<Product>(productViewModel);

            productService.UpdateProduct(product);
        }

        public void DeleteProduct(Guid productId)
        {
            productService.DeleteProduct(productId);
        }
    }
}
