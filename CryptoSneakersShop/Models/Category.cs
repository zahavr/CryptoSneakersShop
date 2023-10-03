using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class Category : ICategory
{
    public string Id { get; }
    
    public string Name { get; }

    public Category(
        string id,
        string name)
    {
        Id = id;
        Name = name;
    }
}