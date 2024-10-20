namespace Controk.Stock.Infrastructure;

using Microsoft.EntityFrameworkCore;

public sealed class StockDbContext(DbContextOptions<StockDbContext> options)
    : DbContext(options)
{
}
