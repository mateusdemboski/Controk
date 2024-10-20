namespace Controk.Product.Infrastructure;

using Controk.Stock.Domain.Models;
using Microsoft.EntityFrameworkCore;

internal sealed class ProductDbContext(DbContextOptions<ProductDbContext> options)
    : DbContext(options)
{
    public DbSet<Category> Categories => this.Set<Category>();

    public DbSet<Product> Products => this.Set<Product>();

    public DbSet<ProductCategory> ProductCategories => this.Set<ProductCategory>();

    public DbSet<ProductItem> ProductItems => this.Set<ProductItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
