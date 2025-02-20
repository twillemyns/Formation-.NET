using Exercice02_Hotel.Models;
using Exercice02_Hotel.Repositories;

namespace Exercice02_Hotel;

internal class MainUI
{
    private static AppController _controller = null!;

    public MainUI(AppController appController)
    {
        _controller = appController;
    }

    public static void Start()
    {
        var choix = "0";

        do
        {
            Console.WriteLine("=== Menu principal ===\n\n" +
                "1. Ajouter un client\n" +
                "2. Afficher la liste des clients\n" +
                "3. Afficher les réservations d'un client\n" +
                "4. Ajouter une réservtion\n" +
                "5. Annuler une réservation\n" +
                "6. Afficher la liste des réservations\n" +
                "0. Quitter");

            Console.Write("Votre choix : ");
            choix = Console.ReadLine();

            switch (choix) {
                case "1":
                    _controller.AddClient();
                    break;
                case "2":
                    _controller.DisplayCustomers();
                    break;
                case "3":
                    _controller.DisplayCustomerBookings();
                    break;
                case "4":
                    _controller.AddBooking();
                    break;
                case "5":
                    _controller.CancelBooking();
                    break;
                case "6":
                    _controller.DisplayReservations();
                    break;
            }
        }
        while (choix != "0");
    }


}
