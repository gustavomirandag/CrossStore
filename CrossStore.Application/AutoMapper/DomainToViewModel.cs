using AutoMapper;
using CrossStore.Application.Models.ViewModels;
using CrossStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
