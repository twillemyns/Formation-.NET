using Exercice05.Models;

namespace Exercice05.Data;

public class MarmosetRepository(ApplicationDbContext context) : IRepository<Marmoset>
{
    public Marmoset? Get(int id)
    {
        return context.Marmosets.Find(id);
    }

    public Marmoset? Get(Func<Marmoset, bool> predicate)
    {
        return context.Marmosets.FirstOrDefault(predicate);
    }

    public IEnumerable<Marmoset> GetAll()
    {
        return context.Marmosets;
    }
    
    public void Add(Marmoset entity)
    {
        context.Marmosets.Add(entity);
        context.SaveChanges();
    }

    public void Delete(Marmoset entity)
    {
        context.Marmosets.Remove(entity);
        context.SaveChanges();
    }

    public void Save()
    {
        context.SaveChanges();
    }
}