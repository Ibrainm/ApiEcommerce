using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos.Category;
using Mapster;

namespace ApiEcommerce.Mapping;

public class CategoryProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Category, CategoryDto>();
        config.NewConfig<CategoryDto, Category>();
        config.NewConfig<CreateCategoryDto, Category>();
        config.NewConfig<Category, CreateCategoryDto>();
    }
}
