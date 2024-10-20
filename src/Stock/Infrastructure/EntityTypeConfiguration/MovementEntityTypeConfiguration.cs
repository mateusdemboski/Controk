namespace Controk.Stock.Infrastructure.EntityTypeConfiguration;

using Controk.Stock.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior;

internal sealed class MovementEntityTypeConfiguration
    : IEntityTypeConfiguration<Movement>
{
    void IEntityTypeConfiguration<Movement>.Configure(EntityTypeBuilder<Movement> builder)
    {
        ArgumentNullException.ThrowIfNull(builder, nameof(builder));

        _ = builder.HasKey(p => p.MovementId);

        builder
            .Property(p => p.CreatedAt)
            .ValueGeneratedOnAdd()
            .Metadata.SetBeforeSaveBehavior(Ignore);

        _ = builder
            .Property(p => p.CreatedBy)
            .IsRequired();

        _ = builder
            .Property(p => p.MovementFrom)
            .IsRequired()
            .HasConversion<string>();

        builder
            .Property(p => p.MovementId)
            .ValueGeneratedOnAdd()
            .Metadata.SetBeforeSaveBehavior(Ignore);

        _ = builder
            .Property(p => p.MovementType)
            .IsRequired()
            .HasConversion<string>();

        _ = builder
            .Property(p => p.NamespaceId)
            .IsRequired();

        _ = builder
            .Property(p => p.ProductItemId)
            .IsRequired();

        _ = builder
            .Property(p => p.Quantity)
            .HasPrecision(15, 6)
            .IsRequired();

        _ = builder
            .Property(p => p.StockPlaceId)
            .IsRequired();

        _ = builder
            .HasOne(p => p.StockPlace)
            .WithMany(p => p.Movements)
            .HasForeignKey(p => p.StockPlaceId);

        _ = builder.HasIndex(p => p.NamespaceId);
        _ = builder.HasIndex(p => new { p.NamespaceId, p.ProductItemId });
    }
}
