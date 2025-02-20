Console.WriteLine("--- Pair ou impair ? ---");
Console.Write("Combien de nombres contiendra le tableau ? ");
var taille = int.Parse(Console.ReadLine()!);

Console.WriteLine("Affectation automatique des valeurs...\n");
Task.Delay(2000).Wait();
var nombres = new int[taille];
var rdm = new Random();

for (int i = 0; i < nombres.Length; i++) 
    nombres[i] = rdm.Next(1, 51);

Console.WriteLine("Vérification des valeurs du tableau :");
foreach (var n in nombres)
{
    var estPair = n % 2 == 0 ? "pair" : "impair";
    Console.WriteLine($"\tLe nombre {n} est {estPair}.");
}