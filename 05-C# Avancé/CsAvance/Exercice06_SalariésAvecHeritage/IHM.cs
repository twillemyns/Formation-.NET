using Exercice02;

namespace Exercice06_SalariésAvecHeritage;

public static class IHM
{
    private static List<Salarie> _salaries = [];
    
    private static int _choix;

    public static void Initialize()
    {
        for (var i = 0; i < 10; i++)
        {
            var r = new Random();
            _salaries.Add(
                new Salarie(
                    r.Next(9999).ToString(),
                    $"Service {i}",
                    "Salarie",
                    $"Salarie {i}",
                    r.Next(1500, 3000))
                );
            _salaries.Add(
                new Commercial(
                    r.Next(9999).ToString(),
                    $"Service {i}",
                    "Commercial",
                    $"Commercial {i}",
                    r.Next(2500, 5000),
                    r.Next(5000),
                    r.NextDouble()));
        }
    }
    
    public static void MainMenu(Action choix1, Action choix2, Action choix3)
    {
        
        do
        {
            Console.WriteLine("===== Gestion des employés =====\n");
            Console.WriteLine("1-- Ajouter un employé\n" +
                              "2-- Afficher le salaire des employés\n" +
                              "3-- Rechercher un employé\n" +
                              "0-- Quitter");
            Console.Write("Faites votre choix :");
            _choix = int.Parse(Console.ReadLine()!);
    
            switch (_choix)
            {
                case 1:
                    choix1();
                    break;
                case 2:
                    choix2();
                    break;
                case 3:
                    choix3();
                    break;
            }
    
        } while (_choix != 0);
    }

    public static void MenuChoix1()
    {
        int choix;
        Console.WriteLine("===== Ajouter un employé =====\n" +
                          "1-- Salarié\n" +
                          "2-- Commercial\n" +
                          "0-- Retour\n");
        
        Console.Write("Entrez votre choix : ");
        choix = int.Parse(Console.ReadLine()!);
        
        if (choix == 0) return; 

        Console.Write("Nom : ");
        var nom = Console.ReadLine();
        Console.Write("Matricule : ");
        var matricule = Console.ReadLine();
        Console.Write("Categorie : ");
        var categorie = Console.ReadLine();
        Console.Write("Service : ");
        var service = Console.ReadLine();
        Console.Write("Salaire : ");
        var salaire = double.Parse(Console.ReadLine()!);
        double ca = 0;
        double commission = 0;
        
        if (choix == 2)
        {
            Console.Write("Chiffre d'affaires du commercial : ");
            ca = double.Parse(Console.ReadLine()!);
            Console.Write("Commission : (en %)");
            commission = double.Parse(Console.ReadLine()!) / 100;
        }

        var salarie = choix switch
        {
            1 => new Salarie(matricule, service, categorie, nom, salaire),
            2 => new Commercial(matricule, service, categorie, nom, salaire, ca, commission),
            _ => null
        };

        if (salarie != null)
        {
            _salaries.Add(salarie);
            Console.WriteLine("Salarié créé.");
        }
        else
        {
            Console.WriteLine("Erreur dans la création du salarié. Retour au menu principal");
        }
    }

    public static void MenuChoix2()
    {
        foreach (var salarie in _salaries)
        {
            Console.WriteLine(salarie);
        }
    }

    public static void MenuChoix3()
    {
        Console.Write("veuillez saisir un nom :");
        var nomchercher = Console.ReadLine();

        var salarie = _salaries.Find(s => s.Name == nomchercher);
        Console.WriteLine(salarie);
    }
}