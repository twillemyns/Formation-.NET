Console.WriteLine("--- Question à choix multiples ---\n");

Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ? :");
Console.WriteLine("\ta) quit\n" +
                  "\tb) continue\n" +
                  "\tc) break\n" +
                  "\td) exit\n");

var choix = "";
bool retry = false;

do
{
    Console.Write("Entrez votre réponse :");
    choix  = Console.ReadLine();

    if (choix == "c")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bonne réponse !");
        Console.ForegroundColor = ConsoleColor.White;
        retry = false;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Mauvaise réponse !");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Souhaitez vous réessayer ? (oui/non)");
        retry = Console.ReadLine() == "oui";
    }

} while (retry);