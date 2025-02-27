namespace Jeux.Pendu;

internal static class GenerateurDeMots
{
    private static readonly string[] mots =
    [
        "lampe", "broche", "voiture", "garage", "kikine", "popote", "pipine", "cacatoes"
    ];

    public static string GenererMot()
    {
        var r = new Random();
        return mots[r.Next(mots.Length)];
    }
}