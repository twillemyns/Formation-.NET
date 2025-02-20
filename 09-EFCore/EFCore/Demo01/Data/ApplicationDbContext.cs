using Demo01.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo01.Data;

internal class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base()
    {
    }

    public DbSet<Livre> Livres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\coursefcore;Integrated Security=True");
    }
}
