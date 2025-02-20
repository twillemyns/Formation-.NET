using Exercice02_Hotel.Data;
using Exercice02_Hotel.Models;

namespace Exercice02_Hotel.Repositories;

internal class RoomRepository(AppDbContext context) : IRepository<Room>
{
    public Room? Get(Func<Room, bool> predicate)
    {
        return context.Rooms.FirstOrDefault(predicate);
    }

    public Room? GetById(int id)
    {
        return context.Rooms.Find(id);
    }

    public IEnumerable<Room> GetAll()
    {
        return context.Rooms;
    }

    public IEnumerable<Room> GetAll(Func<Room, bool> predicate)
    {
        return context.Rooms.Where(predicate);
    }

    public bool Add(Room entity)
    {
        context.Rooms.Add(entity);
        return context.SaveChanges() == 1;
    }

    public bool Delete(int id)
    {
        var room = GetById(id);
        if (room == null)
            return false;

        context.Rooms.Remove(room);
        return context.SaveChanges() == 1;
    }

    public int Save()
    {
        return context.SaveChanges();
    }
}
