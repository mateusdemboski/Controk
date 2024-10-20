namespace Controk.Stock.Infrastructure.EntityTypeConfiguration;

using Controk.Stock.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior;

internal sealed class StockPlaceEntityTypeConfiguration
    : IEntityTypeConfiguration<StockPlace>
{
    void IEntityTypeConfiguration<StockPlace>.Configure(EntityTypeBuilder<StockPlace> builder)
    {
        _ = builder.HasKey(p => p.StockPlaceId);

        _ = builder
            .Property(p => p.Description)
            .HasMaxLength(1000);

        _ = builder
            .Property(p => p.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        _ = builder
            .Property(p => p.IsDefault)
            .IsRequired();

        _ = builder
            .Property(p => p.Name)
            .HasMaxLength(255)
            .IsRequired();

        _ = builder
            .Property(p => p.NamespaceId)
            .IsRequired();

        builder
            .Property(p => p.StockPlaceId)
            .UseIdentityColumn()
            .Metadata.SetBeforeSaveBehavior(Ignore);

        _ = builder
            .Property(p => p.UpdatedAt)
            .ValueGeneratedOnAddOrUpdate()
            .IsConcurrencyToken();

        _ = builder.HasIndex(p => p.NamespaceId);
    }
}
