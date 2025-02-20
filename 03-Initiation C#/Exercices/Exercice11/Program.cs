Console.WriteLine("--- Le nombre est-il divisible par ... ? ---");

Console.WriteLine("Entrez un chiffre/nombre entier :");
var nb = int.Parse(Console.ReadLine());
Console.WriteLine("Entrez un chiffre/nombre entier diviseur:");
var diviseur = int.Parse(Console.ReadLine());

if (nb < 10)
{
    Console.WriteLine(
        nb % diviseur == 0 ?
        "Le chiffre est divisible par " + diviseur :
        "Le chiffre n'est pas divisible par " + diviseur
    );
}
else
{
    Console.WriteLine(
    nb % diviseur == 0 ?
    "Le nombre est divisible par " + diviseur :
    "Le nombre n'est pas divisible par " + diviseur
    );
}