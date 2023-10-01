using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class ProductEditRequest : ProductCreateRequest, IProductEdite
{
    string IProductEdite.Id => throw new NotImplementedException();

    [JsonConstructor]
    public ProductEditRequest() {}
    
    public ProductEditRequest(
        string name,
        string description,
        decimal price) : base(name, description, price)
    {}
}