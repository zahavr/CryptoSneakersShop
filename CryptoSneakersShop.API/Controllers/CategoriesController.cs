using System.ComponentModel.DataAnnotations;
using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.Abstractions.Services;
using CryptoSneakersShop.API.Contracts.Requests;
using CryptoSneakersShop.API.Contracts.Responses;
using CryptoSneakersShop.API.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CryptoSneakersShop.API.Controllers;

[ApiVersion("1.0")]
public class CategoriesController : BaseController
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMany()
    {
        IReadOnlyCollection<ICategory> categories = await _categoryService.GetManyAsync();
        IEnumerable<CategoryResponse> response = categories.Select(category => category.ToResponse());
        
        return Ok(response);
    }

    [HttpGet("{categoryId}")]
    public async Task<IActionResult> Get([FromRoute][Required] string categoryId)
    {
        ICategory category = await _categoryService.GetAsync(categoryId);
        CategoryResponse response = category.ToResponse();
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CategoryCreateRequest request)
    {
        ICategory category = await _categoryService.CreateAsync(request);
        CategoryResponse response = category.ToResponse();
        return Created($"api/v1.0/categories/{response.Id}", response);
    }

    [HttpPut("{categoryId}")]
    public async Task<IActionResult> Edite(
        [FromRoute] [Required] string categoryId,
        [FromBody] CategoryEditeRequest request)
    {
        var category = request.ToModel(categoryId);
        await _categoryService.EditeAsync(category);
        return NoContent();
    }

    [HttpDelete("{categoryId}")]
    public async Task<IActionResult> Delete(string categoryId)
    {
        await _categoryService.DeleteAsync(categoryId);
        return NoContent();
    }
}