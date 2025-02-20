Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");
Console.WriteLine("Entrez la longueur d'un côté du carré (en cm)");
var l = float.Parse(Console.ReadLine()!);

Console.WriteLine("Le périmètre du carré est de : " + (l * 4) + " cm");
Console.WriteLine("L'aire du carré est de :" + Math.Pow(l, 2) + " cm²");

Console.WriteLine("--- Calcul du périmètre et de l'aire d'un rectangle ---");
Console.WriteLine("Entrez la longueur d'un côté du rectangle (en cm)");
var lon = float.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez la largeur d'un côté du rectangle (en cm)");
var lar = float.Parse(Console.ReadLine()!);

Console.WriteLine("Le périmètre du rectangle est de : " + (lon * 2 + lar * 2) + " cm");
Console.WriteLine("L'aire du rectangle est de :" + lon*lar + " cm²");