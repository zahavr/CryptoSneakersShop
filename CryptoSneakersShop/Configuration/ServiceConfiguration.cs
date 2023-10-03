using CryptoSneakersShop.Abstractions.Services;
using CryptoSneakersShop.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoSneakersShop.Configuration;

public static class ServiceConfiguration
{
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IProductService, ProductService>();
        serviceCollection.AddTransient<ICategoryService, CategoryService>();

        return serviceCollection;
    }
}