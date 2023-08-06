using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Services.Products;
using Products.Contracts.Product;

namespace Products.Api.Controllers;

[ApiController]
// [Route("products")]
public class ProductsController: ApiController
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("products")]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        ErrorOr<CreateProductResult> result = _productService.CreateProduct(
            request.Name,
            request.Description,
            request.Price
        );
        return result.Match(
            result => Ok(MapProductResult(result)),
            errors => Problem(errors)
        );
    }

    private static CreateProductResponse MapProductResult(CreateProductResult result)
    {
        return new CreateProductResponse(
                result.Product.Id,
                result.Product.Name,
                result.Product.Description,
                result.Product.Price
        );
    }
}