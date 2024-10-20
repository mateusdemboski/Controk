namespace Controk.Stock.Domain.Models;

public enum MovementFrom
{
    Unknown = 0,
    PurchaseOrder = 1,
    SalesOrder = 2,
    PdvSale = 3,
    PdvCancel = 4,
    BetweenStocks = 5,
}
