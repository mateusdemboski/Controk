namespace Controk.Product.Domain.Contracts;

public sealed record CreateCategoryMessage
{
    public required string CorrelationId { get; init; }

    public string? Description { get; set; }

    public bool IsActive { get; init; } = true;

    public required string Name { get; init; }

    public required Guid NamespaceId { get; init; }
}
