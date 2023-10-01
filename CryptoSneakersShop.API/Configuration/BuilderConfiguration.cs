using CryptoSneakersShop.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoSneakersShop.API.Configuration;

public static class BuilderConfiguration
{
    public static WebApplicationBuilder RegisterBuilder(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddRouting(opt =>
        {
            opt.LowercaseUrls = true;
            opt.LowercaseQueryStrings = true;
        });
        
        builder.Services.AddEndpointsApiExplorer();
        
        builder.Services.AddApiVersioning(opt =>
        {
            opt.DefaultApiVersion = new ApiVersion(1, 0);
            opt.AssumeDefaultVersionWhenUnspecified = true;
            opt.ReportApiVersions = true;
            opt.ApiVersionReader = ApiVersionReader.Combine(
                new UrlSegmentApiVersionReader(),
                new HeaderApiVersionReader("x-api-version"),
                new MediaTypeApiVersionReader("x-api-version"));
        });

        builder.Services.AddVersionedApiExplorer(setup =>
        {
            setup.GroupNameFormat = "'v'VVV";
            setup.SubstituteApiVersionInUrl = true;
        });
        
        builder.Services.AddSwaggerGen();

        builder.Services.AddServices();

        return builder;
    }
}