using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class CategoryEdite : ICategoryEdite
{
    public string Id { get; }
    
    public string Name { get; }

    public CategoryEdite(
        string id,
        string name)
    {
        Id = id;
        Name = name;
    }
}