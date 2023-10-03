using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Models;

public class CategoryCreate : ICategoryCreate
{
    public string Name { get; }

    public CategoryCreate(string name)
    {
        Name = name;
    }
}