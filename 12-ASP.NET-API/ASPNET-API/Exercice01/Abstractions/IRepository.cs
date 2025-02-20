namespace Exercice01.Abstractions;

public interface IRepository<T> where T : class
{
    T? Get(Guid id);

    IEnumerable<T> Get(Func<T, bool> predicate);

    IEnumerable<T> GetAll();

    void Add(T entity);

    void Update(T entity);

    void Delete(Guid id);
}