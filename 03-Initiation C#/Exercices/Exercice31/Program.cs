Console.WriteLine("======= Gestion des contacts =======");

Console.Write("Merci de saisir le nombre de contacts :");
var nbContacts = int.Parse(Console.ReadLine()!);
Console.Clear();
var contacts = new string[nbContacts];
int choix;

do
{
    menu();
    Console.Clear();
    switch (choix)
    {
        case 1:
            choix1();
            break;
        case 2:
            choix2();
            break;
    } 

    Console.Clear();
} while (choix != 0);


void menu()
{
    Console.WriteLine("----- Ma liste de contacts -----\n" +
                      "1---- Saisir des contacts\n" +
                      "2---- Afficher mes contacts\n" +
                      "0---- Quitter\n");

    Console.WriteLine("Faites votre choix : ");
    choix = int.Parse(Console.ReadLine()!);
}

void choix1()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ Saisir les contacts ------");
    Console.ResetColor();

    for (var i = 0; i < nbContacts; i++)
    {
        Console.Write($"Nom et prénom du contact n°{i + 1} : ");
        contacts[i] = Console.ReadLine()!;
    }
}

void choix2()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ Affichage des contacts ------");
    Console.ResetColor();

    foreach (var c in contacts)
        Console.WriteLine($"Contact n° {Array.IndexOf(contacts, c)} : {c}");

    Console.WriteLine("Appuyer sur Entrée pour revenir au menu...");
    Console.ReadLine();
}