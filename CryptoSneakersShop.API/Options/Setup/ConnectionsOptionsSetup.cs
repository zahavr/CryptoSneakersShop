using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CryptoSneakersShop.API.Options.Setup;

public class ConnectionsOptionsSetup : IConfigureOptions<ConnectionsOptions>
{
    private const string SectionName = "Connections";
    private readonly IConfiguration _configuration;

    public ConnectionsOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public void Configure(ConnectionsOptions options)
    {
        _configuration
            .GetSection(SectionName)
            .Bind(options);
    }
}