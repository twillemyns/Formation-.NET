Console.WriteLine("--- Gestion des notes ---\n");

Console.WriteLine("Veuillez saisir 5 notes :");

float somme = 0;
float min = 20;
float max = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"\t- Merci de saisir la note {i + 1} (/20) :");
    float note = float.Parse(Console.ReadLine());

    somme += note;

    if (note < min) min = note;

    if (note > max) max = note;
}

float moyenne = somme / 5;

Console.WriteLine($"La meilleure note est {max}/20");
Console.WriteLine($"La pire note est {min}/20");
Console.WriteLine($"La moyenne des notes est {moyenne}/20");