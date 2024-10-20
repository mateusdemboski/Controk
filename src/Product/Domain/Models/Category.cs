namespace Controk.Stock.Domain.Models;

public sealed class Category
{
    public Guid CategoryId { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; } = default!;

    public Guid NamespaceId { get; set; }
}
