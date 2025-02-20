namespace Exercice01;

internal class Chaise
{
    public int NbPieds { get; set; } = 4;

    public string? Materiau { get; set; } = "air";

    public string Couleur { get; set; } = "transparent";

    public Chaise() { }

    public Chaise(int nbPieds, string materiau, string couleur)
    {
        NbPieds = nbPieds;
        Materiau = materiau;
        Couleur = couleur;
    }

    public override string ToString()
        => $"Je suis une chaise, avec {NbPieds} pieds en {Materiau} et de couleur {Couleur}";

}
