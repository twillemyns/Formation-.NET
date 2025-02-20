using System.ComponentModel.DataAnnotations;

namespace Exercice06.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Le message doit faire moins de {0} caractères")]
    public string Name { get; set; } = null!;
    
    [Required]
    public DateOnly ReleaseDate { get; set; }

    public bool IsWatched { get; set; }

    [StringLength(50)]
    public string PictureUrl { get; set; } = null!;
}