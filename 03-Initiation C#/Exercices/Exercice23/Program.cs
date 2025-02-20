Console.WriteLine("Hauteur du triangle :");
int h = int.Parse(Console.ReadLine());

int k = h;
for (int i = 0; i < h; i++)
{
    for (int j = k; j >= 0; j--)
    {
        Console.Write(" ");
    }
    var nbEtoiles = (h - k) * 2 + 1;
    for (int x = 0; x < nbEtoiles; x++)
    {
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
    k--;
}