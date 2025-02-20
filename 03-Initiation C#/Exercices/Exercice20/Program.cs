Console.WriteLine("--- Les tables de multiplications ---\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Table de {i + 1} :");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"\t- {i+1} x {j+1} = {(i+1)*(j+1)}");
    }
}