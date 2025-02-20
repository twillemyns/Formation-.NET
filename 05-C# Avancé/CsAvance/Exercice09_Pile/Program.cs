using Exercice09_Pile;

IPile? pile;
string? choix;
do
{
    Console.WriteLine("Quel type utiliser ?");
    Console.WriteLine("1. String");
    Console.WriteLine("2. Decimal");
    Console.WriteLine("3. Classe Personne");
    choix = Console.ReadLine();
    pile = choix switch
    {
        "1" => new Pile<string>(),
        "2" => new Pile<decimal>(),
        "3" => new Pile<Personne>(),
        _ => null
    };
} while (pile is null);

do
{
    Console.WriteLine("=== Menu principal ===\n");

    Console.WriteLine("1. Empiler");
    Console.WriteLine("2. Dépiler");
    Console.WriteLine("3. Extraire");
    Console.WriteLine("0. Quitter");

    Console.WriteLine("Votre choix :");
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
    }
} while (choix != "0");

return;

void Choix1()
{
    switch (pile)
    {
        case Pile<string> phrases:
            Console.WriteLine("Phrase à ajouter :");
            var phrase = Console.ReadLine();
            phrases.Empiler(phrase);
            break;
        case Pile<decimal> nombres:
            Console.WriteLine("Valeur à ajouter :");
            var nombre = decimal.Parse(Console.ReadLine());
            nombres.Empiler(nombre);
            break;
        case Pile<Personne> personnes:
            Console.WriteLine("Nom : ");
            var nom = Console.ReadLine();
            Console.WriteLine("Prénom : ");
            var prenom = Console.ReadLine();
            Console.WriteLine("Age : ");
            var age = int.Parse(Console.ReadLine());
            var personne = new Personne
            {
                Nom = nom,
                Prenom = prenom,
                Age = age
            };
            personnes.Empiler(personne);
            break;
    }
}

void Choix2()
{
    switch (pile)
    {
        case Pile<string> phrases:
            phrases.Depiler();
            break;
        case Pile<decimal> nombres:
            nombres.Depiler();
            break;
        case Pile<Personne> personnes:
            personnes.Depiler();
            break;
    }

    Console.WriteLine("Dernière expression enlevée !");
}

void Choix3()
{
    Console.WriteLine("Index de l'élément à extraire :");
    var index = int.Parse(Console.ReadLine());
    switch (pile)
    {
        case Pile<string> phrases:
            var phrase = phrases.ExtraireElement(index);
            Console.WriteLine($"Phrase extraite : {phrase}");
            break;
        case Pile<decimal> nombres:
            var nombre = nombres.ExtraireElement(index);
            Console.WriteLine($"Phrase extraite : {nombre::N2}");
            break;
        case Pile<Personne> personnes:
            var personne = personnes.ExtraireElement(index);
            Console.WriteLine($"Personne extraite : {personne.Prenom} {personne.Nom}");
            break;
    }
}