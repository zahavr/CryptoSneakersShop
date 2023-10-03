using System.ComponentModel.DataAnnotations;
using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.Abstractions.Services;
using CryptoSneakersShop.API.Contracts.Requests;
using CryptoSneakersShop.API.Contracts.Responses;
using CryptoSneakersShop.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CryptoSneakersShop.API.Controllers;

[ApiVersion("1.0")]
public class ProductsController : BaseController
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMany()
    {
        IReadOnlyCollection<IProduct> products = await _productService.GetManyAsync();
        IEnumerable<ProductResponse> response = products.Select(product => product.ToResponse());
        
        return Ok(response);
    }

    [HttpGet("{productId}")]
    public async Task<IActionResult> Get([FromRoute][Required] string productId)
    {
        IProduct product = await _productService.GetAsync(productId);
        ProductResponse response = product.ToResponse();
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
    {
        IProduct product = await _productService.CreateAsync(request);
        ProductResponse response = product.ToResponse();
        return Created($"api/v1.0/products/{response.Id}", response);
    }

    [HttpPut("{productId}")]
    public async Task<IActionResult> Edite(
        [FromRoute] [Required] string productId,
        [FromBody] ProductEditeRequest request)
    {
        var product = request.ToModel(productId);
        await _productService.EditeAsync(product);
        return NoContent();
    }

    [HttpDelete("{productId}")]
    public async Task<IActionResult> Delete(string productId)
    {
        await _productService.DeleteAsync(productId);
        return NoContent();
    }
}