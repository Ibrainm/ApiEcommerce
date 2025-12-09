using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos.Product;
using Mapster;

namespace ApiEcommerce.Mapping;

public class ProductProfile: IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Product, ProductDto>()
            .Map(dest => dest.CategoryName, src => src.Category.Name);
        
        config.NewConfig<ProductDto, Product>();
        config.NewConfig<CreateProductDto, Product>();
        config.NewConfig<Product, CreateProductDto>();
        config.NewConfig<UpdateProductDto, Product>();
        config.NewConfig<Product, UpdateProductDto>();
    }
}
