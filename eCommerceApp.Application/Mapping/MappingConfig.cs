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
            CreateMap<CreateProduct, Category>();

            CreateMap<Category, GetCategory>();
            CreateMap<Category, GetProduct>();

            CreateMap<UpdateCategory, Category>();
            CreateMap<UpdateProduct, Category>();
        }
    }
}
