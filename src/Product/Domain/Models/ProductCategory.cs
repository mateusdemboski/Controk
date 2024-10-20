namespace Controk.Stock.Domain.Models;

public sealed class ProductCategory
{
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; } = default!;

    public Guid NamespaceId { get; set; }

    public Guid ProductCategoryId { get; set; }
}
