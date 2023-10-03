using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.Abstractions.Services;

namespace CryptoSneakersShop.Services;

internal class CategoryService : ICategoryService
{
    public Task<IReadOnlyCollection<ICategory>> GetManyAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ICategory> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<ICategory> CreateAsync(ICategoryCreate request)
    {
        throw new NotImplementedException();
    }

    public Task EditeAsync(ICategoryEdite request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }
}