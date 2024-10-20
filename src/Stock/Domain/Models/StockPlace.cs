namespace Controk.Stock.Domain.Models;

public sealed class StockPlace
{
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public bool IsDefault { get; set; }

    public ICollection<Movement> Movements { get; private set; } = [];

    public string Name { get; set; } = default!;

    public Guid NamespaceId { get; init; }

    public Guid StockPlaceId { get; init; }

    public TimeSpan UpdatedAt { get; set; }
}
