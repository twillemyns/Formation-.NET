Console.WriteLine("--- Calcul de la longueur de l'hypothénuse ---");
Console.WriteLine("Entrez la longueur du premier coté (en cm):");
var coté1 = float.Parse(Console.ReadLine());
Console.WriteLine("Entrez la longueur du second coté (en cm):");
var coté2  = float.Parse(Console.ReadLine());
Console.WriteLine("La longueur de l'hypothénuse est de :" + Math.Sqrt(Math.Pow(coté1, 2) + Math.Pow(coté2, 2)).ToString("N2") + " cm");