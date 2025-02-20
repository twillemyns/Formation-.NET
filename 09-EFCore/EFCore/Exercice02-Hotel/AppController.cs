using Exercice02_Hotel.Models;
using Exercice02_Hotel.Repositories;
using System.Reflection.Metadata.Ecma335;

namespace Exercice02_Hotel;

internal class AppController(
    IRepository<Customer> customerRep,
    IRepository<Room> roomRep,
    IRepository<Booking> bookingRep,
    IRepository<Hotel> hotemRep)
{
    public void AddClient()
    {
        Console.Write("Nom de famille: ");
        var lastName = Console.ReadLine()!;

        Console.WriteLine("Prénom: ");
        var firstName = Console.ReadLine()!;

        Console.WriteLine("Numéro de téléphone: ");
        var phone = Console.ReadLine()!;

        var newCustomer = new Customer
        {
            LastName = lastName,
            FirstName = firstName,
            TelNumber = phone
        };

        var isSucced = customerRep.Add(newCustomer);

        Console.WriteLine(isSucced ? "Ajout confirmé !" : "Erreur dans l'ajout, veuillez réessayer");
    }

    internal void AddBooking()
    {
        foreach (var item in customerRep.GetAll())
        {
            Console.WriteLine(item);
        }

        Console.Write("Choisissez l'id du client : ");
        var idCustomer = int.Parse(Console.ReadLine()!);
        Customer customer;
        do
        {
            customer = customerRep.GetById(idCustomer);

            if (customer == null) 
                Console.WriteLine("Client non trouvé. Veuillez réessayer.");
        } while (customer is null);

        var rooms = new List<Room>();
        var roomNumber = string.Empty;
        foreach (var item in roomRep.GetAll(r => r.Status == RoomStatus.Free))
        {
            Console.WriteLine(item);
        }

        Console.Write("Choisissez le numéro de chambre : ");
        roomNumber = Console.ReadLine();
        Room? room;
        do
        {
            room = roomRep.Get(r => r.Number == roomNumber);
            if (room is null)
            {
                Console.WriteLine("Aucune chambre n'a été trouvée. Veuillez réessayer.");
            }
        } while (room is null);

        room.Status = RoomStatus.Occupied;
        roomRep.Save();
        
        bookingRep.Add(new Booking
        {
            Customer = customer,
            Room = room
        });
    }

    internal void CancelBooking()
    {
        bool isSucceed;
        do
        {
            foreach (var item in bookingRep.GetAll())
            {
                Console.WriteLine(item);
            }
            Console.Write("Veuillez choisir l'ID de la réservation à annuler");
            isSucceed = bookingRep.Delete(int.Parse(Console.ReadLine()!));
            if (!isSucceed)
            {
                Console.WriteLine("Aucune réservation trouvée. Veuillez réessayer.");
            }
        } while (!isSucceed);
    }

    internal void DisplayCustomerBookings()
    {
        throw new NotImplementedException();
    }

    internal void DisplayCustomers()
    {
        throw new NotImplementedException();
    }

    internal void DisplayReservations()
    {
        throw new NotImplementedException();
    }
}