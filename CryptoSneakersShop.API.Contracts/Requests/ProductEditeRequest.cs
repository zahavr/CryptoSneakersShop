using System.Text.Json.Serialization;
using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.API.Contracts.Requests;

public class ProductEditeRequest : ProductCreateRequest, IProductEdite
{
    string IProductEdite.Id => throw new NotImplementedException();
    
    public CategoryEditeRequest Category { get; set; }

    ICategoryEdite IProductEdite.Category => Category;

    [JsonConstructor]
    public ProductEditeRequest() {}
    
    public ProductEditeRequest(
        string name,
        string description,
        decimal price,
        CategoryEditeRequest categoryEditeRequest) : base(name, description, price, categoryEditeRequest)
    {}
}