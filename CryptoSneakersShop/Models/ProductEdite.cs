using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class ProductEdite : IProductEdite
{
    public string Id { get; }
    
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }

    public ProductEdite(
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