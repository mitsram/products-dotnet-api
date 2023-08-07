using Mapster;
using Products.Application.Products.Common;
using Products.Contracts.Products;

namespace Products.Api.Common.Mapping;

public class ProductMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ProductResult, CreateProductResponse>()
            .Map(dest => dest, src => src.Product);
    }
}