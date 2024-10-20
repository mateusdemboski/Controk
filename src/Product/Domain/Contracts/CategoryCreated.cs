namespace Controk.Product.Domain.Contracts;

public sealed record CategoryCreated
{
    public Guid CategoryId { get; init; }

    public Guid CorrelationId { get; init; }
}
