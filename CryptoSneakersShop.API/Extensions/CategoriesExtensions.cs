using CryptoSneakersShop.Abstractions.Models;
using CryptoSneakersShop.API.Contracts.Responses;
using CryptoSneakersShop.Models;

namespace CryptoSneakersShop.API.Extensions;

internal static class CategoriesExtensions
{
    public static CategoryResponse ToResponse(this ICategory category)
    {
        return new CategoryResponse(
            category.Id,
            category.Name);
    }

    public static ICategoryEdite ToModel(this ICategoryEdite request, string categoryId)
    {
        return new CategoryEdite(
            categoryId,
            request.Name);
    }
}