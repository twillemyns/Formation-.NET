using Exercice06.Models;

namespace Exercice06.Data;

public class MovieRepository(AppDbContext context) : IRepository<Movie>
{
    public Movie? Get(int id)
    {
        return context.Movies.Find(id);
    }

    public Movie? Get(Func<Movie, bool> predicate)
    {
        return context.Movies.FirstOrDefault(predicate);
    }

    public IEnumerable<Movie> GetAll()
    {
        return context.Movies;
    }

    public void Add(Movie entity)
    {
        context.Movies.Add(entity);
    }

    public void Delete(Movie entity)
    {
        context.Movies.Remove(entity);
    }

    public void Update(Movie entity)
    {
        var movie = context.Movies.Find(entity.Id);
        
        if (movie is null) return;
        
        movie.Name = entity.Name;
        movie.ReleaseDate = entity.ReleaseDate;
        movie.IsWatched = entity.IsWatched;
        
        context.SaveChanges();
    }
}