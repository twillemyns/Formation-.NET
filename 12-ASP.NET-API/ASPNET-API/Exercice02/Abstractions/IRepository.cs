using System.Linq.Expressions;

namespace Exercice02.Abstractions;

public interface IRepository<T> where T : class
{
    Task<T?> Get(Guid id);
    
    Task<T?> Get(Expression<Func<T, bool>> predicate);

    Task<IEnumerable<T>> GetAll(Func<T, bool> predicate);

    Task<IEnumerable<T>> GetAll();

    Task<bool> Any(Expression<Func<T, bool>> predicate);

    Task Add(T entity);

    Task Update(T entity);

    Task Delete(Guid id);
}