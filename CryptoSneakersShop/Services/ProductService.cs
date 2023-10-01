using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.Abstractions.Services;
using CryptoSneakersShop.Models;

namespace CryptoSneakersShop.Services;

internal class ProductService : IProductService
{
    public async Task<IReadOnlyCollection<IProduct>> GetManyAsync()
    {
        IReadOnlyList<Product> products = new List<Product>()
        {
            new("1", "name1", "description1", 0),
            new("2", "name2", "description2", 0),
        };

        return await Task.FromResult(products);
    }

    public async Task<IProduct> GetAsync(string id)
    {
        Product product = new Product(id, "name", "desc", 0);

        return await Task.FromResult(product);
    }

    public async Task<IProduct> CreateAsync(IProductCreate request)
    {
        Product product = new Product("1", request.Name, request.Description, request.Price);

        return await Task.FromResult(product);
    }

    public async Task EditAsync(IProductEdite request)
    {
        await Task.CompletedTask;
    }

    public async Task DeleteAsync(string id)
    {
        await Task.CompletedTask;
    }
}