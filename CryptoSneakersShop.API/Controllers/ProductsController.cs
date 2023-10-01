using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CryptoSneakersShop.API.Controllers;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class ProductsController : BaseController
{
    [HttpGet]
    public async Task<IReadOnlyList<string>> GetMany()
    {
        return await Task.FromResult(new[] { "My Strings" });
    }

    [HttpGet("{productId}")]
    public async Task<string> Get([FromRoute] [Required] string productId)
    {
        return await Task.FromResult(productId);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] string request)
    {
        return Created(new Uri($"api/v1.0/Products/asd"), string.Empty);
    }

    [HttpPut("{productId}")]
    public async Task<IActionResult> Edit(
        [FromRoute] [Required] string productId,
        [FromBody] string request)
    {
        return NoContent();
    }

    [HttpDelete("{productId}")]
    public async Task<IActionResult> Delete(string request)
    {
        return NoContent();
    }
}