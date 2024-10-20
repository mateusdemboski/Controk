namespace Controk.Stock.Domain.Models;

public sealed class ProductItem
{
    public Guid ProductId { get; set; }

    public Guid ProductItemId { get; set; }

    public Guid? StockPlaceId { get; set; }
}
