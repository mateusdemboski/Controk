namespace Controk.Extensions.Mapping;

using Controk.Extensions.Mapping.Abstractions;
using Microsoft.Extensions.DependencyInjection;

internal sealed class Builder(IServiceProvider services)
    : IBuilder
{
    TOutput IBuilder.Build<TInput, TOutput>(TInput input)
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        using var scope = services.CreateScope();

        return scope.ServiceProvider
            .GetRequiredService<IBuilder<TInput, TOutput>>()
            .Build(input);
    }
}
