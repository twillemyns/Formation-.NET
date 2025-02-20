using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercice02.Models;

public class Ingredient
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }
    
    [StringLength(50)]
    public required string Name { get; set; }
    
    [StringLength(150)]
    public required string Description { get; set; }

    public IEnumerable<Pizza> Pizzas { get; set; } = [];
}