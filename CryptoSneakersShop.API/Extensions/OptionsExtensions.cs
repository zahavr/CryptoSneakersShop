using CryptoSneakersShop.API.Options.Setup;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoSneakersShop.API.Extensions;

internal static class OptionsExtensions
{
    public static IServiceCollection AddConfigurations(this IServiceCollection services)
    {
        services.ConfigureOptions<ConnectionsOptionsSetup>();
        
        return services;
    }
}