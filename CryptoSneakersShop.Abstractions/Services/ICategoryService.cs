using CryptoSneakersShop.Abstractions.Models;

namespace CryptoSneakersShop.Abstractions.Services;

public interface ICategoryService
{
    Task<IReadOnlyCollection<ICategory>> GetManyAsync();

    Task<ICategory> GetAsync(string id);

    Task<ICategory> CreateAsync(ICategoryCreate request);

    Task EditeAsync(ICategoryEdite request);

    Task DeleteAsync(string id);
}