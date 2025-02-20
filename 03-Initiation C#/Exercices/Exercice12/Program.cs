Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ? ---");

Console.WriteLine("Entrez l'age de votre enfant :");
var age = int.Parse(Console.ReadLine());

if (age < 3)
    Console.WriteLine("Votre enfant est trop jeune pour être intégré.");
else if (age >= 18)
    Console.WriteLine("Votre enfant vient d'acquérir la majorité et est donc en capacité de faire des choix en son ame et conscience.");
else
{
    var categorie = age switch
    {
        > 12 => "Cadet",
        > 10 => "Minime",
        > 8 => "Pupille",
        > 6 => "Poussin",
        _ => "Baby"
    };

    Console.WriteLine($"Votre enfant est dans la catégorie \"{categorie}\" !");
}