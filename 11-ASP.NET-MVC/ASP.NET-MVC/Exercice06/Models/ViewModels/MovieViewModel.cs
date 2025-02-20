using System.ComponentModel.DataAnnotations;

namespace Exercice06.Models.ViewModels;

public class MovieViewModel
{
    public int Id { get; init; }
    
    public string Name { get; init; } = null!;

    public DateOnly ReleaseDate { get; init; }

    public bool IsWatched { get; init; }
    
    public string Path { get; init; } = null!;   
}