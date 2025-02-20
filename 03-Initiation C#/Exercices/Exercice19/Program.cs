Console.WriteLine("--- Menus et sous-menus ---\n");

Console.WriteLine("Table des matières :\n");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"\tChapitre {i + 1}");
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"\t\t-Partie {i + 1}.{j + 1}");
    }
}