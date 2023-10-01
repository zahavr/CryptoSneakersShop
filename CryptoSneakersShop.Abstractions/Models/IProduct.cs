namespace CryptoSneakersShop.Abstractions.Models;

public interface IProduct
{
    string Id { get; }
    
    string Name { get; }
    
    string Description { get; }
    
    decimal Price { get; }
}