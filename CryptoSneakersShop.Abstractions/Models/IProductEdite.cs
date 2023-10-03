namespace CryptoSneakersShop.Abstractions.Models;

public interface IProductEdite : IProductCreate
{
    string Id { get; }
    
    ICategoryEdite Category { get; }
}