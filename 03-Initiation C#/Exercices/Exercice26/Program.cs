Console.WriteLine("--- Trouver le nombre mystère ---\n");

Random rdm = new Random();
int mystere = rdm.Next(1, 51);
int nombre = 0;
int nbTentatives = 0;

do
{
    nbTentatives++;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\tVeuillez saisir un nombre : ");
    nombre = int.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Red;
    if (nombre > mystere)
        Console.WriteLine("\t\tLe nombre mystère est plus petit");
    else if (nombre < mystere)
        Console.WriteLine("\t\tLe nombre mystère est plus grand");
}
while (nombre != mystere);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bravo !!!! Vous avez trouvé le nombre mystère !\n");
Console.WriteLine($"Vous l'avez trouvé en {nbTentatives} tentatives.");
Console.ForegroundColor = ConsoleColor.White;