namespace Exercice05.Data;

public interface IRepository<T> where T : class
{
    T? Get(int id);

    T? Get(Func<T, bool> predicate);

    IEnumerable<T> GetAll();

    void Add(T entity);

    void Delete(T entity);

    void Save();
}