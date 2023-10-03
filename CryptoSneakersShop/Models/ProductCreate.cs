using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class ProductCreate : IProductCreate
{
    public string Name { get; }
    
    public string Description { get; }
    
    public decimal Price { get; }
    
    public ICategoryCreate Category { get; }

    public ProductCreate(
        string name,
        string description,
        decimal price,
        CategoryCreate categoryCreate)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = categoryCreate;
    }
}