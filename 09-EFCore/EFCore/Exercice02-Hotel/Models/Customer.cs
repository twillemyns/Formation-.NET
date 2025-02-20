namespace Exercice02_Hotel.Models;

internal class Customer
{
    public int Id { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string TelNumber { get; set; } = null!;

    public IEnumerable<Booking> Bookings { get; set; } = [];

    public override string ToString()
    {
        return $"ID: {Id} | Nom : {LastName} | Prénom : {FirstName} | Tél: {TelNumber}";
    }
}
