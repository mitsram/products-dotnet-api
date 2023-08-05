using Microsoft.AspNetCore.Mvc;
using Products.Application.Services.Product;
using Products.Contracts.Product;

namespace Products.Api.Controllers;

[ApiController]
// [Route("products")]
public class ProductsController: ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("products")]
    public IActionResult CreateProduct(CreateProductRequest request)
    {
        var result = _productService.CreateProduct(
            request.Name,
            request.Description,
            request.Price
        );

        var response = new CreateProductResponse(
            result.Id,
            result.Name,
            result.Description,
            result.Price
        );
        
        return Ok(response);
    }
}