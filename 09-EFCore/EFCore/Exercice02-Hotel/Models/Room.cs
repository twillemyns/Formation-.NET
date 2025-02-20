namespace Exercice02_Hotel.Models;

internal class Room
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public RoomStatus Status { get; set; }

    public int NbBeds { get; set; }

    public double Price { get; set; }

    public Hotel Hotel { get; set; } = null!;

    public override string ToString()
    {
        return $"Numéro : {Number} | Statut : {Status} | Nombre de lits : {NbBeds} | Prix : {Price}";
    }
}

internal enum RoomStatus
{
    Free,
    Occupied,
    BeingCleaned
}
