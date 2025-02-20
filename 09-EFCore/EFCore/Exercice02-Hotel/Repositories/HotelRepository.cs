using Exercice02_Hotel.Data;
using Exercice02_Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02_Hotel.Repositories;

internal class HotelRepository(AppDbContext context) : IRepository<Hotel>
{
    public Hotel? Get(Func<Hotel, bool> predicate)
    {
        return context.Hotels.FirstOrDefault(predicate);
    }

    public Hotel? GetById(int id)
    {
        return context.Hotels
            .Include(h => h.Rooms)
            .SingleOrDefault(h => h.Id == id);
    }

    public IEnumerable<Hotel> GetAll()
    {
        return context.Hotels;
    }

    public IEnumerable<Hotel> GetAll(Func<Hotel, bool> predicate)
    {
        return context.Hotels.Where(predicate);
    }

    public bool Add(Hotel entity)
    {
        context.Hotels.Add(entity);

        return context.SaveChanges()  > 0;
    }

    public bool Delete(int id)
    {
        var hotel = context.Hotels.Find(id);
        if (hotel == null) return false;

        context.Hotels.Remove(hotel);
        return context.SaveChanges() > 0;
    }

    public int Save()
    {
        return context.SaveChanges();
    }
}
