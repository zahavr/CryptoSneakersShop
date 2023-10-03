using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class CategoryCreateRequest : ICategoryCreate
{
    public string Name { get; set; }
    
    [JsonConstructor]
    public CategoryCreateRequest(){}
    
    public CategoryCreateRequest(string name)
    {
        Name = name;
    }
}