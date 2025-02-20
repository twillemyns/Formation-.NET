Console.WriteLine("Entrez le prix HT de l'objet (en €) :");
var prix = float.Parse(Console.ReadLine()!);
Console.WriteLine("Entrez ke taux de TVA (en %) :");
var taux = float.Parse(Console.ReadLine()!);

var tauxPrix = prix * taux / 100;

Console.WriteLine("Le montant de la TVA est de " + tauxPrix + " €");
Console.WriteLine("Le prix TTC de l'objet est de " + (prix + tauxPrix).ToString("N2") + " €");