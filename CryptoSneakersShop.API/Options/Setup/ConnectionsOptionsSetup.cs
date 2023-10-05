using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CryptoSneakersShop.API.Options.Setup;

public class ConnectionsOptionsSetup : IConfigureOptions<ConnectionsOptions>
{
    private readonly IConfiguration _configuration;

    public ConnectionsOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void Configure(ConnectionsOptions options)
    {
        _configuration
            .GetSection(ConnectionsOptions.Key)
            .Bind(options);
    }
}