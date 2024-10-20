namespace Controk.Extensions.Mapping;

using System.Reflection;
using Controk.Extensions.Mapping.Abstractions;
using Microsoft.Extensions.DependencyInjection;

public static class MappingRegistrationExtensions
{
    public static IServiceCollection AddMapping(
        this IServiceCollection services,
        Assembly assembly,
        ServiceLifetime lifetime = ServiceLifetime.Singleton)
    {
        ArgumentNullException.ThrowIfNull(assembly, nameof(assembly));

        return services.Scan(scan => scan
            .FromAssemblies(assembly)
            .AddClasses(filter => filter
                .AssignableTo(typeof(IBuilder<,>)))
            .AsImplementedInterfaces()
            .WithLifetime(lifetime))
            .AddTransient<IBuilder, Builder>();
    }
}
