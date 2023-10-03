using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class ProductCreateRequest : IProductCreate
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }

    public CategoryCreateRequest Category { get; set; }
    
    ICategoryCreate IProductCreate.Category => Category;

    [JsonConstructor]
    public ProductCreateRequest(){}

    public ProductCreateRequest(
        string name,
        string description,
        decimal price,
        CategoryCreateRequest categoryCreateRequest)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = categoryCreateRequest;
    }
}