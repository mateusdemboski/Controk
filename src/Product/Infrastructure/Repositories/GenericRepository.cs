namespace Controk.Product.Infrastructure.Repositories;

using Ardalis.Specification.EntityFrameworkCore;

internal sealed class GenericRepository<TEntity>(ProductDbContext dbContext) :
    RepositoryBase<TEntity>(dbContext),
    IRepository<TEntity>
    where TEntity : class
{
}
