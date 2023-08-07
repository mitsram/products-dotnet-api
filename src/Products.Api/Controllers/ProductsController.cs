

using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.CreateProduct;
using Products.Application.Products.Common;
using Products.Contracts.Products;

namespace Products.Api.Controllers;

[ApiController]
public class ProductsController: ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ProductsController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("products")]
    public async Task<IActionResult> CreateProduct(CreateProductRequest request)
    {
        var command = _mapper.Map<CreateProductCommand>(request);
        ErrorOr<ProductResult> result = await _mediator.Send(command);
        
        return result.Match(
            result => Ok(_mapper.Map<CreateProductResponse>(result)),
            errors => Problem(errors)
        );
    }
}