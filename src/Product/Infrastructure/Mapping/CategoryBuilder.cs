namespace Controk.Product.Infrastructure.Mapping;

using Controk.Extensions.Mapping.Abstractions;
using Controk.Product.Domain.Contracts;
using Controk.Stock.Domain.Models;

internal sealed class CategoryBuilder : IBuilder<CreateCategoryMessage, Category>
{
    Category IBuilder<CreateCategoryMessage, Category>.Build(CreateCategoryMessage input)
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        return new()
        {
            Description = input.Description,
            IsActive = input.IsActive,
            Name = input.Name,
            NamespaceId = input.NamespaceId,
        };
    }
}
