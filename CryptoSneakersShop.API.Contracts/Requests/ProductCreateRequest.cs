using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class ProductCreateRequest : IProductCreate
{
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }
    
    [JsonConstructor]
    public ProductCreateRequest()
    {}

    public ProductCreateRequest(
        string name,
        string description,
        decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}