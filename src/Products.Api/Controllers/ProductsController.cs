

using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.CreateProduct;
using Products.Application.Products.Common;
using Products.Contracts.Product;

namespace Products.Api.Controllers;

[ApiController]
// [Route("products")]
public class ProductsController: ApiController
{
    private readonly ISender _mediator;

    public ProductsController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("products")]
    public async Task<IActionResult> CreateProduct(CreateProductRequest request)
    {
        var command = new CreateProductCommand(request.Name, request.Description, request.Price);
        ErrorOr<ProductResult> result = await _mediator.Send(command);
        
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