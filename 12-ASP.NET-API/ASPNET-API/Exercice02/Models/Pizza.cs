using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercice02.Models;

public class Pizza
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }

    [StringLength(50)]
    public required string Name { get; set; }
    
    [StringLength(150)]
    public required string Description { get; set; }
    
    public double Price { get; set; }
    
    public PizzaStatus Status { get; set; }

    public IEnumerable<Ingredient> Ingredients { get; set; } = [];
}

public enum PizzaStatus
{
    Vegetarian,
    Spicy
}