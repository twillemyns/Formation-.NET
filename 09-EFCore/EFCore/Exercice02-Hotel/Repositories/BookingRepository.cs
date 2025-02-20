
using Exercice02_Hotel.Data;
using Exercice02_Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02_Hotel.Repositories;

internal class BookingRepository(AppDbContext context) : IRepository<Booking>
{
    public Booking? Get(Func<Booking, bool> predicate)
    {
        return context.Bookings
            .Include(b => b.Customer)
            .Include(b => b.Room)
            .FirstOrDefault(predicate);
    }

    public Booking? GetById(int id)
    {
        return context.Bookings
            .Include(b => b.Customer)
            .Include(b => b.Room)
            .SingleOrDefault(b => b.Id == id);
    }

    public IEnumerable<Booking> GetAll()
    {
        return context.Bookings;
    }

    public IEnumerable<Booking> GetAll(Func<Booking, bool> predicate)
    {
        return context.Bookings.Where(predicate);
    }

    public bool Add(Booking entity)
    {
        context.Add(entity);
        return context.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var booking = context.Bookings.Find(id);
        if (booking == null) return false;

        context.Bookings.Remove(booking);
        return context.SaveChanges() > 0;
    }

    public int Save()
    {
        return context.SaveChanges();
    }
}