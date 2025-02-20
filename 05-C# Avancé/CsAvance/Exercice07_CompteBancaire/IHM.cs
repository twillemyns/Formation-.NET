using System.Threading.Channels;

namespace Exercice07_CompteBancaire;

public static class IHM
{
    private static Client _client;

    private static int _choix;

    public static void Start()
    {
        var mainMenu = new Menu("Menu principal",
            new KeyValuePair<string, Action>("Lister les comptes bancaires", Choix1),
            new KeyValuePair<string, Action>("Créer un compte bancaire", Choix2),
            new KeyValuePair<string, Action>("Effectuer un dépôt", Choix3),
            new KeyValuePair<string, Action>("Effectuer un retrait", Choix4),
            new KeyValuePair<string, Action>("Afficher les opérations et le solde", Choix5),
            new KeyValuePair<string, Action>("Quitter le programme", (() => { }))
        );

        do
        {
            Console.WriteLine(mainMenu);
            _choix = int.Parse(Console.ReadLine()!);
            mainMenu.Choose(_choix);
        } while (_choix != 6);
    }

    private static void Choix1()
    {
        foreach (var compte in _client.ComptesBancaires)
        {
            Console.WriteLine(compte);
        }
    }

    private static void Choix2()
    {
        var createMenu = new Menu("Création de compte",
            new KeyValuePair<string, Action>("Créer un compte courant", CreationCompteCourant),
            new KeyValuePair<string, Action>("Créer un compte épargne", CreationCompteEpargne),
            new KeyValuePair<string, Action>("Créer un compte payant", CreationComptePayant),
            new KeyValuePair<string, Action>("Annuler la création de compte", () => { })
        );

        do
        {
            Console.WriteLine(createMenu);
            _choix = int.Parse(Console.ReadLine()!);
            createMenu.Choose(_choix);
        } while (_choix != 4);
    }

    private static void CreationCompteCourant()
    {
        Console.Write("Combien d'argent dans le compte ?");
        var initSolde = double.Parse(Console.ReadLine()!);

        _client.ComptesBancaires.Add(new CompteCourant
        {
            Client = _client,
            Solde = initSolde,
            Operations =
            [
                new Operation()
                {
                    Montant = initSolde,
                    Numero = 1,
                    Statut = Statut.Depot
                }
            ]
        });
    }

    private static void CreationCompteEpargne()
    {
        Console.Write("Combien d'argent dans le compte ?");
        var initSolde = double.Parse(Console.ReadLine()!);

        _client.ComptesBancaires.Add(new CompteEpargne
        {
            Client = _client,
            Solde = initSolde,
            Operations =
            [
                new Operation()
                {
                    Montant = initSolde,
                    Numero = 1,
                    Statut = Statut.Depot
                }
            ]
        });
    }

    private static void CreationComptePayant()
    {
        Console.Write("Combien d'argent dans le compte ?");
        var initSolde = double.Parse(Console.ReadLine()!);

        _client.ComptesBancaires.Add(new ComptePayant
        {
            Client = _client,
            Solde = initSolde,
            Operations =
            [
                new Operation()
                {
                    Montant = initSolde,
                    Numero = 1,
                    Statut = Statut.Depot
                }
            ]
        });
    }

    private static void Choix3()
    {
        var liste = new List<KeyValuePair<string, Action>>();
        foreach (var compte in _client.ComptesBancaires)
        {
            liste.Add(new KeyValuePair<string, Action>(compte.ToString(), DeposerArgent));
        }
        liste.Add(new KeyValuePair<string, Action>("Annuler", () => { }));
        var menu = new Menu("Choix du compte", liste);
        do
        {
            Console.WriteLine(menu);
            var choix = int.Parse(Console.ReadLine()!);
            menu.Choose(choix);
        } while (_choix != _client.ComptesBancaires.Count);
    }

    private static void DeposerArgent()
    {
        throw new NotImplementedException();
    }

    private static void Choix4()
    {
        throw new NotImplementedException();
    }

    private static void Choix5()
    {
        throw new NotImplementedException();
    }
}