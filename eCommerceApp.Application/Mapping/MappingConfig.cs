using AutoMapper;
using eCommerceApp.Application.DTOs.Category;
using eCommerceApp.Application.DTOs.Product;
using eCommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerceApp.Application.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CreateCategory, Category>();
            CreateMap<CreateProduct, category>();

            CreateMap<Category, GetCategory>();
            CreateMap<category, GetProduct>();

            CreateMap<UpdateCategory, Category>();
            CreateMap<UpdateProduct, category>();
        }
    }
}
