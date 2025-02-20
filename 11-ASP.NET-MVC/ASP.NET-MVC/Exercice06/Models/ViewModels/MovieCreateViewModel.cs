using System.ComponentModel.DataAnnotations;

namespace Exercice06.Models.ViewModels;

public class MovieCreateViewModel
{
    [Required]
    [StringLength(50, ErrorMessage = "Le message doit faire moins de {0} caractères")]
    public string Name { get; set; } = null!;
    
    [Required]
    public DateOnly ReleaseDate { get; set; }

    public bool IsWatched { get; set; }
    
    public IFormFile File { get; set; } = null!;

}