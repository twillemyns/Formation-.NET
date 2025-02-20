using Exercice01.Data;
using Exercice01.Models;

using var context = new AppDbContext();

var choix = "0";

do
{
    Console.WriteLine("\t1. Créer un personnage" +
        "\r\n\t2. Mettre à jour un personnage" +
        "\r\n\t3. Afficher tous les personnages" +
        "\r\n\t4. Taper un personnage" +
        "\r\n\t5. Afficher les personnages ayant des PVs (PV + armure) supérieurs à la moyenne" +
        "\r\n\t0. Quitter");

    Console.Write("\nVeuillez faire un choix: ");
    choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            Choix1();
            break;
        case "2":
            Choix2();
            break;
        case "3":
            Choix3();
            break;
        case "4":
            Choix4();
            break;
        case "5":
            Choix5();
            break;
    }
}
while (choix != "0");

void Choix1()
{
    Console.Write("Veuillez entrer un pseudo: ");
    var pseudo = Console.ReadLine();
    Console.Write("Veuillez entrer un nombre de points de vie: ");
    var pointsDeVie = int.Parse(Console.ReadLine());
    Console.Write("Veuillez entrer un nombre de points d'armure: ");
    var armure = int.Parse(Console.ReadLine());
    Console.Write("Veuillez entrer un nombre de points de dégats: ");
    var degats = int.Parse(Console.ReadLine());
    Console.Write("Veuillez entrer un nombre de nombre de personnes tuées: ");
    var nbPersonnesTuees = int.Parse(Console.ReadLine());

    context.Personnages.Add(new Personnage
    {
        Pseudo = pseudo!,
        PointsDeVie = pointsDeVie,
        Armure = armure,
        Degats = degats,
        NombrePersonnesTuees = nbPersonnesTuees
    });

    context.SaveChanges();
    Console.WriteLine("Personnage créé");
    Console.ReadLine();
}

void Choix2()
{
    Console.Write("Saisissez le pseudo du personnage à modifier : ");
    var pseudo = Console.ReadLine();

    var perso = context.Personnages.FirstOrDefault(p => p.Pseudo == pseudo);

    if (perso == null)
    {
        Console.WriteLine("Aucun personnage trouvé avec ce nom. Retour au menu");
        return;
    }

    Console.WriteLine($"Pseudo : {perso.Pseudo}");
    Console.WriteLine("Ecrivez le nouveau pseudo ou faites Entrez si vous ne souhaitez pas le changer :");
    var newPseudo = Console.ReadLine();
    perso.Pseudo = newPseudo != string.Empty ? newPseudo : perso.Pseudo;

    Console.WriteLine($"Points de vie : {perso.PointsDeVie}");
    Console.WriteLine("Ecrivez le nouveau nombre de points de vie ou faites Entrez si vous ne souhaitez pas le changer :");
    var isParse = int.TryParse(Console.ReadLine(), out int newPointsDeVie);
    perso.PointsDeVie = isParse ? newPointsDeVie : perso.PointsDeVie;

    Console.WriteLine($"Armure : {perso.Armure}");
    Console.WriteLine("Ecrivez le nouveau nombre de points d'armure ou faites Entrez si vous ne souhaitez pas le changer :");
    isParse = int.TryParse(Console.ReadLine(), out int newArmure);
    perso.Armure = isParse ? newArmure : perso.Armure;

    Console.WriteLine($"Dégats : {perso.Degats}");
    Console.WriteLine("Ecrivez le nouveau nombre de points de dégats ou faites Entrez si vous ne souhaitez pas le changer :");
    isParse = int.TryParse(Console.ReadLine(), out int newDegats);
    perso.Degats = isParse ? newDegats : perso.Degats;

    Console.WriteLine($"Personnes tuées : {perso.NombrePersonnesTuees}");
    Console.WriteLine("Ecrivez le nouveau nombre de points d'armure ou faites Entrez si vous ne souhaitez pas le changer :");
    isParse = int.TryParse(Console.ReadLine(), out int newNbPersonnesTuees);
    perso.NombrePersonnesTuees = isParse ? newNbPersonnesTuees : perso.NombrePersonnesTuees;

    context.SaveChanges();

    Console.WriteLine("Changements effectués");
    Console.ReadLine();
}

void Choix3()
{
    context.Personnages.ToList().ForEach(Console.WriteLine);
}

void Choix4()
{
    Console.WriteLine("Saisissez le pseudo du personnage attaquant :");
    var pseudoAttaquant = Console.ReadLine();
    Console.WriteLine("Saisissez le peudo du personnage défenseur :");
    var pseudoDefenseur = Console.ReadLine();

    var attaquant = context.Personnages.FirstOrDefault(p => p.Pseudo == pseudoAttaquant);
    var defenseur = context.Personnages.FirstOrDefault(p => p.Pseudo == pseudoDefenseur);

    if (attaquant is null || defenseur is null)
    {
        Console.WriteLine("L'attaquant et/ou le défenseur n'a/ont pas été trouvé. Retour au menu");
        return;
    }

    if (attaquant.Degats > defenseur.Armure)
    {
        defenseur.PointsDeVie -= attaquant.Degats - defenseur.Armure;

        if (defenseur.PointsDeVie <= 0)
        {
            Console.WriteLine($"{defenseur.Pseudo} n'a plus de points de vie. Il est supprimé.");
            context.Personnages.Remove(defenseur);
        }
        else
        {
            Console.WriteLine($"{defenseur.Pseudo} n'a plus que {defenseur.PointsDeVie} points de vie.");
        }
    }
    else
    {
        Console.WriteLine($"{defenseur.Pseudo} a trop d'armure, il n'a pas pris de dégats");
    }

    context.SaveChanges();

}

void Choix5()
{
    var moyenne = context.Personnages.Select(p => p.PointsDeVie + p.Armure).Average();
    var joueurs = context.Personnages.Where(p => p.PointsDeVie + p.Armure > moyenne).ToList();

    Console.WriteLine(joueurs);
}