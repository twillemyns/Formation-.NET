Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---");

Console.WriteLine("Longueur AB :");
var AB = float.Parse(Console.ReadLine());
Console.WriteLine("Longueur BC :");
var BC = float.Parse(Console.ReadLine());
Console.WriteLine("Longueur CA :");
var CA = float.Parse(Console.ReadLine());

if (AB == BC)
{
    if (AB == CA)
        Console.WriteLine("Le triangle est équilatéral.");
    else
        Console.WriteLine("Le triangle est isocèle en B");
}
else if (BC == CA)
    Console.WriteLine("Le triangle est isocèle en C");
else if (CA == AB)
    Console.WriteLine("Le triangle est isocèle en A");
else
    Console.WriteLine("Le triangle n'est pas isocèle");