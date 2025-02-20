Console.WriteLine("--- La lettre est-elle une voyelle ? ---");

Console.WriteLine("Entrez une lettre :");
var lettre = Console.ReadLine();

var voyelles = "aeiouyAEIOUY";

if (voyelles.Contains(lettre))
{
    Console.WriteLine("Voyelle");
}
else
{
    Console.WriteLine("Pas voyelle");
}