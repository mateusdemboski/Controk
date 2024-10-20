namespace Controk.Product.Infrastructure;

using Controk.Product.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class InfrastructureRegistrationExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services, nameof(services));

        return services
            .AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
    }
}
