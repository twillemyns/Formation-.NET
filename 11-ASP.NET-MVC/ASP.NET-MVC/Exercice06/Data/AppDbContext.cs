using Exercice06.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice06.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Movie>().HasData(
    //         new Movie()
    //         {
    //             Id = 1,
    //             Name = "The Shawshank Redemption",
    //             ReleaseDate = new DateOnly(1994, 10, 14),
    //             IsWatched = true
    //         },
    //         new Movie()
    //         {
    //             Id = 2,
    //             Name = "The Godfather",
    //             ReleaseDate = new DateOnly(1972, 3, 24),
    //             IsWatched = true
    //         },
    //         new Movie()
    //         {
    //             Id = 3,
    //             Name = "The Dark Knight",
    //             ReleaseDate = new DateOnly(2008, 7, 18),
    //             IsWatched = true
    //         });
    // }
}