using Exercice05_Pendu;

Pendu pendu = null;
string? choix;
do
{
    var mot = GenerateurDeMots.GenererMot();
    Console.WriteLine("Voulez vous un nombre d'essais spécifique (10 par défaut) ? o/n");
    choix = Console.ReadLine();
    switch (choix)
    {
        case "o":
            Console.WriteLine("Combien d'essais ?");
            var nbEssais = int.Parse(Console.ReadLine()!);
            pendu = new Pendu(mot, nbEssais);
            break;
        case "n":
            pendu = new Pendu(mot);
            break;
        default:
            Console.WriteLine("Choix non reconnu. Veuillez réésayer.");
            break;
    }
}
while (choix is null);

while (pendu!.NbEssais > 0 && !pendu.TestWin())
{
    Console.WriteLine($"Le mot à trouver : {pendu.Masque}");
    Console.WriteLine($"Il vous reste {pendu.NbEssais} essais.");
    Console.Write("Veuillez saisir une lettre : ");
    var lettre = char.Parse(Console.ReadLine()!);
    pendu.TestChar(lettre);
    pendu.NbEssais--;
}

if (pendu.NbEssais == 0)
{
    Console.WriteLine($"Perdu !!! Le mot à trouver était : {pendu.MotATrouver}");
}
else if (pendu.TestWin())
{
    Console.WriteLine("Gagné !!!");
}