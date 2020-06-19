using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CrossStore.Application.Models.ViewModels;
using CrossStore.Domain.Entities;

namespace CrossStore.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}
