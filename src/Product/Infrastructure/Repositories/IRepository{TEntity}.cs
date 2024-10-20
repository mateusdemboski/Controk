namespace Controk.Product.Infrastructure.Repositories;

using Ardalis.Specification;

public interface IRepository<TEntity> : IRepositoryBase<TEntity>
    where TEntity : class
{
}
