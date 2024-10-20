namespace Controk.Stock.Domain.Models;

public sealed class Movement
{
    public TimeSpan CreatedAt { get; init; }

    public Guid CreatedBy { get; init; }

    public MovementFrom MovementFrom { get; init; }

    public Guid MovementId { get; init; }

    public MovementType MovementType { get; init; }

    public Guid NamespaceId { get; init; }

    public Guid ProductItemId { get; init; }

    public decimal Quantity { get; init; }

    public StockPlace? StockPlace { get; init; }

    public Guid? StockPlaceId { get; init; }
}
