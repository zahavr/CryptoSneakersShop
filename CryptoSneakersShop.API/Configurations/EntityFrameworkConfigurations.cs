using CryptoSneakersShop.API.Options;
using CryptoSneakersShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CryptoSneakersShop.API.Configurations;

public static class EntityFrameworkConfigurations
{
    public static IServiceCollection AddEntityFramework(
        this IServiceCollection serviceCollection,
        IServiceProvider serviceProvider)
    {
        ConnectionsOptions? connections = serviceProvider.GetService<IOptions<ConnectionsOptions>>()?.Value;

        if (connections is null) throw new ArgumentNullException();

        serviceCollection.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connections.SQLServer);
        });

        return serviceCollection;
    }
}