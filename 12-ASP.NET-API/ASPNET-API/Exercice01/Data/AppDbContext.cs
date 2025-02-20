using Exercice01.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice01.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Contact> Contacts { get; set; }
}