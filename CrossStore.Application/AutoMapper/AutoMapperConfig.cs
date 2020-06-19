using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            var config = new MapperConfiguration(mapper => {
                mapper.AddProfile<DomainToViewModel>();
                mapper.AddProfile<ViewModelToDomain>();
            });
            return config;
        }
    }
}
