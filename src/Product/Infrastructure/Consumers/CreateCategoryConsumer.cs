namespace Controk.Product.Infrastructure.Consumers;

using Controk.Extensions.Mapping.Abstractions;
using Controk.Product.Domain.Contracts;
using Controk.Product.Infrastructure.Repositories;
using Controk.Stock.Domain.Models;
using MassTransit;

internal sealed class CreateCategoryConsumer(
    IBuilder builder,
    IRepository<Category> categoriesRepository)
    : IConsumer<CreateCategoryMessage>
{
    async Task IConsumer<CreateCategoryMessage>.Consume(ConsumeContext<CreateCategoryMessage> context)
    {
        var category = await categoriesRepository
            .AddAsync(
                builder.Build<CreateCategoryMessage, Category>(context.Message),
                context.CancellationToken)
            .ConfigureAwait(false);

        _ = await categoriesRepository
            .SaveChangesAsync(context.CancellationToken)
            .ConfigureAwait(false);
    }
}
