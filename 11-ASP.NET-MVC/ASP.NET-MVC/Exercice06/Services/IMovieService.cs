using Exercice06.Models.ViewModels;

namespace Exercice06.Services;

public interface IMovieService
{
    public IEnumerable<MovieViewModel> GetAll();
    
    public MovieViewModel? Create(MovieCreateViewModel vm);
}