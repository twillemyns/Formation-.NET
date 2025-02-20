namespace Exercice02_Hotel.Models;

internal class Hotel
{
    public int Id { get; set; }

    public IEnumerable<Room> Rooms { get; set; } = [];
}