using AutoMapper;
using BlazorApp_Data;
using BlazorApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_Business.Maper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<ProductDTO, Product>().ReverseMap();
            //Usa-se o reverseMap para nao ter que fazer o codigo abaixo:
            //CreateMap<Category, CategoryDTO>()
        }
    };
}
