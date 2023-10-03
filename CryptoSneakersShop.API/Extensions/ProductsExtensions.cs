using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.API.Contracts.Responses;
using CryptoSneakersShop.Models;

namespace CryptoSneakersShop.API.Extensions;

internal static class ProductsExtensions
{
    public static ProductResponse ToResponse(this IProduct product)
    {
        return new ProductResponse(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.Category);
    }

    public static IProductEdite ToModel(this IProductEdite request, string productId)
    {
        return new ProductEdite(
            productId,
            request.Name,
            request.Description,
            request.Price,
            request.Category);
    }
}