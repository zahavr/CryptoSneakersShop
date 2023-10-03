using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class CategoryEditeRequest : CategoryCreateRequest, ICategoryEdite
{
    string ICategoryEdite.Id => throw new NotImplementedException();
    
    [JsonConstructor]
    public CategoryEditeRequest() {}
    
    public CategoryEditeRequest(string name) : base(name) {}
}