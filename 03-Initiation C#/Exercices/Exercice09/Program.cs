Console.WriteLine("--- Calcul des intêrets ---");
Console.WriteLine();
Console.WriteLine("Entrez Capital de départ (En €) :");
var capital = float.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez le taux d'intérêt (en %) :");
var taux = float.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez la duré de l'épargne (en années) :");
var nbAnnees = int.Parse(Console.ReadLine()!);

var newCapital = capital * Math.Pow((1 + taux/100), nbAnnees);

Console.WriteLine($"Le montant des intérêts sera de {newCapital - capital:N2} € après {nbAnnees} ans.");
Console.WriteLine($"Le capital final sera de {newCapital:N2} €");