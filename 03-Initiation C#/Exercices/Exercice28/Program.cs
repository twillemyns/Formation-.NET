Console.WriteLine("Insertion des valeurs du tableau :");

var nombres = new int[10];

for (var i = 0; i < 10; i++)
{
    Console.Write($"Insérer la valeur {i+1} : ");
    nombres[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Affichage des valeurs du tableau :");
var message = "";
for (var i = 0; i < nombres.Length; i++)
{
    for (var j = 0; j < i; j++) 
        Console.Write("\t");
    
    Console.WriteLine(nombres[i]);
}