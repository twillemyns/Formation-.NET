namespace Exercice05_Pendu;

internal class Pendu
{
    public string Masque { get; set; } = string.Empty;

    public int NbEssais { get; set; }

    public string MotATrouver { get; set; }

    public Pendu(string motATrouver, int nbEssais = 10)
    {
        NbEssais = nbEssais;
        MotATrouver = motATrouver;
        for (var i = 0; i < motATrouver.Length; i++)
        {
            Masque += '*';
        }
    }

    public void TestChar(char lettre)
    {
        if (!MotATrouver.Contains(lettre))
            return;
        
        var newMasque = "";
        var i = 0;
        foreach (var t in MotATrouver)
        {
            newMasque += t == lettre ? t : Masque[i];
            i++;
        }

        Masque = newMasque;
    }

    public bool TestWin()
    {
        return !Masque.Contains('*');
    }
}