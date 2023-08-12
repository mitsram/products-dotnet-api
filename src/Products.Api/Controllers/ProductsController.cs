

using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.CreateProduct;
using Products.Application.Products.Queries;
using Products.Contracts.Products;

namespace Products.Api.Controllers;

[ApiController]
[Route("products")]
public class ProductsController: ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ProductsController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductRequest request)
    {
        var command = _mapper.Map<CreateProductCommand>(request);

        var createProductResult = await _mediator.Send(command);

        return createProductResult.Match(
            product => Ok(_mapper.Map<ProductResponse>(product)),
            errors => Problem(errors));
    }

    [HttpGet]
    public async Task<IActionResult> ListProducts(string hostId)
    {
        var query = _mapper.Map<ListProductsQuery>(hostId);

        var listDinnersQuery = await _mediator.Send(query);

        return listDinnersQuery.Match(
            dinners => Ok(dinners.Select(dinner => _mapper.Map<ProductResponse>(dinner))),
            errors => Problem(errors));
    }
}