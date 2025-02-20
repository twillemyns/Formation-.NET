namespace Exercice05_Pendu;

internal static class GenerateurDeMots
{
    private static readonly string[] mots =
    [
        "lama", "broc", "voix", "gaga", "kiki", "popo", "pipi", "caca"
    ];

    public static string GenererMot()
    {
        var r = new Random();
        return mots[r.Next(mots.Length)];
    }
}