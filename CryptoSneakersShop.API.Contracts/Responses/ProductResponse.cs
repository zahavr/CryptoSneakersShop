using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Responses;

public class ProductResponse : IProduct
{
    public string Id { get; }
    
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }

    public ProductResponse(
        string id,
        string name,
        string description,
        decimal price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }
}