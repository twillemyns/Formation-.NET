(float somme, float difference, float quotient, float produit) operation(float nb1, float nb2)
    => (nb1 + nb2, nb1 - nb2, nb1 / nb2, nb1 * nb2);

Console.Write("Numéro 1 : ");
var nb1 = float.Parse(Console.ReadLine()!);
Console.Write("Numéro 2 : ");
var nb2 = float.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Somme : {operation(nb1, nb2).somme}\n" +
                  $"Différence : {operation(nb1, nb2).difference}\n" +
                  $"Quotient : {operation(nb1, nb2).quotient}\n" +
                  $"Produit : {operation(nb1, nb2).produit}");