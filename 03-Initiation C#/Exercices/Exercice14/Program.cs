Console.WriteLine("Taille ? :");
var taille = float.Parse(Console.ReadLine()!);
Console.WriteLine("Poids :");
var poids = float.Parse(Console.ReadLine()!);

if (taille <= 157)
{
    if (poids <= 65)
        Console.WriteLine("1");
    else
        Console.WriteLine("pas de taille dispo");
}
else if (taille == 160)
{
    if (poids >= 72)
        Console.WriteLine("Pas de taille dispo");
    else if (poids >= 66)
        Console.WriteLine("2");
    else
        Console.WriteLine("1");
}
else if (taille == 163)
{
    if (poids >= 72)
        Console.WriteLine("3");
    else if (poids >= 60)
        Console.WriteLine("2");
    else
        Console.WriteLine("1");
}
else if (taille == 166)
{
    if (poids >= 72)
        Console.WriteLine("3");
    else if (poids >= 54)
        Console.WriteLine("2");
    else
        Console.WriteLine("1");
}
else if (taille == 169)
{
    if (poids >= 72)
        Console.WriteLine("3");
    else if (poids >= 48)
        Console.WriteLine("2");
    else
        Console.WriteLine("1");
}
else if (taille == 172)
{
    if (poids >= 66)
        Console.WriteLine("3");
    else if (poids >= 48)
        Console.WriteLine("2");
    else
        Console.WriteLine("pas de taille dispo");
}
else if (taille == 175)
{
    if (poids >= 60)
        Console.WriteLine("3");
    else if (poids >= 48)
        Console.WriteLine("2");
    else
        Console.WriteLine("pas de taille dispo");
}
else if (taille == 178)
{
    if (poids >= 54)
        Console.WriteLine("3");
    else if (poids >= 48)
        Console.WriteLine("2");
    else
        Console.WriteLine("pas de taille dispo");
}
else if (taille == 183)
{
    if (poids > 54)
        Console.WriteLine("3");
    else
        Console.WriteLine("pas de taille dispo");
}