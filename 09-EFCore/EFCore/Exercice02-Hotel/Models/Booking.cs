namespace Exercice02_Hotel.Models;

internal class Booking
{
    public int Id { get; set; }

    public Room Room { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

}

internal enum BookingStatus
{
    Planned,
    Standing,
    Finished,
    Cancelled
}