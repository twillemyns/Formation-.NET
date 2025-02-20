string[] nonTires = ["Jean", "Jacques", "Paul", "Yvette"];
string[] Tires = [];

var choix = 0;

do
{
    menu();
    
    switch (choix)
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
} while (choix != 0);

void menu()
{
    Console.WriteLine("--- Le grand tirage au sort ---\n");
    
    Console.WriteLine("1---Effectuer un tirage");
    Console.WriteLine("2---Voir la liste des personnes déjà tirées");
    Console.WriteLine("3---Voir la liste des personnes restantes");
    Console.WriteLine("0---Quitter\n");

    Console.Write("Faites votre choix :");
    choix = int.Parse(Console.ReadLine()!);
    
    Console.Clear();
}

void choix1()
{
    var r = new Random();
    var gagnant = nonTires[r.Next(0, nonTires.Length)];

    Tires = Tires.Append(gagnant).ToArray();
    nonTires = Array.FindAll(nonTires, s => s != gagnant).ToArray();

    var etoiles = "";
    for (int i = 0; i < gagnant.Length; i++)
    {
        etoiles += "*";
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"*****************{etoiles}****");
    Console.WriteLine($"* Le gagnant est {gagnant} ! *");
    Console.WriteLine($"*****************{etoiles}****");
    Console.ResetColor();
}

void choix2()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("*************************************");
    Console.WriteLine("* Liste des personnes déja tirées : *");
    Console.WriteLine("*************************************");
    Console.ResetColor();
    
    for (var i = 0; i < nonTires.Length; i++)
    {
        for (var j = 0; j < i; j++) 
            Console.Write(" ");
    
        Console.WriteLine(nonTires[i]);
    }
}

void choix3()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("*************************************");
    Console.WriteLine("* Liste des personnes déja tirées : *");
    Console.WriteLine("*************************************");
    Console.ResetColor();

    for (var i = 0; i < Tires.Length; i++)
    {
        for (var j = 0; j < i; j++) 
            Console.Write(" ");
    
        Console.WriteLine(Tires[i]);
    }
}