using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class Product : IProduct
{
    public string Id { get; }
    
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }
    
    public ICategory Category { get; }

    public Product(
        string id,
        string name,
        string description,
        decimal price,
        Category category)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
}