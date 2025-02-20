using Exercice02_Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02_Hotel.Data;

internal class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Room> Rooms { get; set; }

    public DbSet<Booking> Bookings { get; set; }

    public DbSet<Hotel> Hotels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\exhotelefcore;Integrated Security=True");
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<>()
    // }
}
