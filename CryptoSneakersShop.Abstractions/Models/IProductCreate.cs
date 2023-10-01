namespace CryptoSneakersShop.Abstractions.Models;

public interface IProductCreate
{
    string Name { get; }
    
    string Description { get; }
    
    decimal Price { get; }
}