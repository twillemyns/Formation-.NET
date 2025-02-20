using Exercice06.Data;
using Exercice06.Models;
using Exercice06.Models.ViewModels;

namespace Exercice06.Services;

public class MovieService(AppDbContext context, IUploadPictureService uploadPictureService) : IMovieService
{
    public IEnumerable<MovieViewModel> GetAll()
    {
        return context.Movies.Select(ToViewModel);
    }

    public MovieViewModel? GetById(int id)
    {
        var movie = context.Movies.Find(id);
        if (movie is null) return null;
        return ToViewModel(movie);
    }

    // Point de départ pour le formulaire de récupération de l'image
    public MovieViewModel? Create(MovieCreateViewModel vm)
    {
        var movie = ToEntity(vm);
        context.Movies.Add(movie);
        context.SaveChanges();

        return ToViewModel(movie);
    }

    private Movie ToEntity(MovieCreateViewModel vm)
    {
        return new Movie()
        {
            Name = vm.Name,
            ReleaseDate = vm.ReleaseDate,
            IsWatched = vm.IsWatched,
            PictureUrl = uploadPictureService.Upload(vm.File) ??
                         throw new ArgumentNullException(nameof(vm), "Fichier vide")
        };
    }

    private MovieViewModel ToViewModel(Movie movie)
    {
        return new MovieViewModel()
        {
            Id = movie.Id,
            Name = movie.Name,
            Path = movie.PictureUrl
        };
    }
}