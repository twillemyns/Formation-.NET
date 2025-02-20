Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---");

Console.WriteLine("Liste des boissons disponibles :\n" +
    "\t1) Eau plate\n" +
    "\t2) Eau gazeuse\n" +
    "\t3) Coca-Cola\n" +
    "\t4) Fanta\n" +
    "\t5) Sprite\n" +
    "\t6) Orangina\n" +
    "\t7) 7Up");

Console.Write("Faites votre choix (1 à 7) :");
int nb = int.Parse(Console.ReadLine()!);

var boisson = nb switch
{
    1 => "eau plate",
    2 => "eau gazeuse",
    3 => "Coca-Cola",
    4 => "Fanta",
    5 => "Sprite",
    6 => "Orangina",
    7 => "7Up",
    _ => "Erreur"
};

if (boisson == "Erreur")
    Console.WriteLine("Une erreur d'est produite, veuillez relancer l'application.");
else
    Console.WriteLine($"Votre {boisson} est servie !");