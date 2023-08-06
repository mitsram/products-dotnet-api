using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Services.Products;
using Products.Application.Services.Products.Commands;
using Products.Application.Services.Products.Common;
using Products.Application.Services.Products.Queries;
using Products.Contracts.Product;

namespace Products.Api.Controllers;

[ApiController]
// [Route("products")]
public class ProductsController: ApiController
{
    private readonly IProductCommandService _productCommandService;
    private readonly IProductQueryService _productQueryService;

    public ProductsController(IProductCommandService productCommandService, IProductQueryService productQueryService)
    {
        _productCommandService = productCommandService;
        _productQueryService = productQueryService;
    }

    [HttpPost("products")]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        ErrorOr<ProductResult> result = _productCommandService.CreateProduct(
            request.Name,
            request.Description,
            request.Price
        );
        return result.Match(
            result => Ok(MapProductResult(result)),
            errors => Problem(errors)
        );
    }

    private static CreateProductResponse MapProductResult(ProductResult result)
    {
        return new CreateProductResponse(
                result.Product.Id,
                result.Product.Name,
                result.Product.Description,
                result.Product.Price
        );
    }
}