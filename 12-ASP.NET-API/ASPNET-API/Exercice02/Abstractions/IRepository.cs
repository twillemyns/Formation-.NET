namespace Exercice02.Abstractions;

public interface IRepository<T> where T : class
{
    Task<T?> Get(Guid id);

    Task<IEnumerable<T>> Get(Func<T, bool> predicate);

    Task<IEnumerable<T>> GetAll();

    Task Add(T entity);

    Task Update(T entity);

    Task Delete(Guid id);
}