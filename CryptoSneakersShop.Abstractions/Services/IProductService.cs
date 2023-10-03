using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Abstractions.Services;

public interface IProductService
{
    Task<IReadOnlyCollection<IProduct>> GetManyAsync();

    Task<IProduct> GetAsync(string id);

    Task<IProduct> CreateAsync(IProductCreate request);

    Task EditeAsync(IProductEdite request);

    Task DeleteAsync(string id);
}