using Exercice02.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Pizza> Pizzas { get; set; }
    
    public DbSet<Ingredient> Ingredients { get; set; }
    
    public DbSet<User> Users { get; set; }
}