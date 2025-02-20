Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? ---");
Console.WriteLine();

Console.WriteLine("Dernier salaire (en €) :");
var salaire = int.Parse(Console.ReadLine()!);
Console.WriteLine("Age :");
var age = int.Parse(Console.ReadLine()!);
Console.WriteLine("Années d'ancienneté :");
var anciennete = int.Parse(Console.ReadLine()!);

var indemnite = 0;

if (anciennete <= 10)
    indemnite += (salaire / 2) * anciennete;
else
    indemnite += salaire * anciennete;

if (age > 45)
    indemnite += age switch
    {
        < 50 => salaire * 2,
        >= 50 => salaire * 5
    };

Console.WriteLine("Votre indemnité est de :" + indemnite + " €");