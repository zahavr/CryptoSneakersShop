using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class ProductCreate : IProductCreate
{
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }

    public ProductCreate(
        string name,
        string description,
        decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}