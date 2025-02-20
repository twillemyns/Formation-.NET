using Exercice05.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice05.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Marmoset> Marmosets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Marmoset>().HasData(
            new Marmoset()
            {
                Id = 1,
                Name = "Premier",
                Age = 2
            },
            new Marmoset()
            {
                Id = 2,
                Name = "Deuxième",
                Age = 6
            }
        );
    }
}