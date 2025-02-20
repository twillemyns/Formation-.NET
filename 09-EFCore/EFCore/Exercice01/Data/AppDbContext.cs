using Exercice01.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice01.Data;

internal class AppDbContext : DbContext
{
    public DbSet<Personnage> Personnages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\exercice01efcore;Integrated Security=True");
    }
}
