using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Responses;

public class CategoryResponse : ICategory
{
    public string Id { get; }
    
    public string Name { get; }
    
    public CategoryResponse(
        string id,
        string name)
    {
        Id = id;
        Name = name;
    }
}