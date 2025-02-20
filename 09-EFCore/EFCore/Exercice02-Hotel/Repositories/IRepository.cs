namespace Exercice02_Hotel.Repositories;

internal interface IRepository<T> where T : class
{
    T? GetById(int id);

    T? Get(Func<T, bool> predicate);

    IEnumerable<T> GetAll();

    IEnumerable<T> GetAll(Func<T, bool> predicate);

    bool Add(T entity);

    bool Delete(int id);

    int Save();
}
