namespace Controk.Stock.Domain.Models;

public sealed class Product
{
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; } = default!;

    public Guid NamespaceId { get; set; }

    public Guid ProductId { get; set; }

    public Guid ProductCategoryId { get; set; }

    public Guid ProductTypeId { get; set; }

    public int Quantity { get; set; }
}
