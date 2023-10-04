using CryptoSneakersShop.API.Options;
using CryptoSneakersShop.API.Options.Setup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoSneakersShop.API.Configuration;

internal static class OptionsExtensions
{
    public static IServiceCollection AddConfigurations(this IServiceCollection services)
    {
        services.ConfigureOptions<ConnectionsOptionsSetup>();

        return services;
    }
}