namespace Exercice01.Models;

internal class Personnage
{
    public int Id { get; set; }

    public string Pseudo { get; set; } = null!;

    public int PointsDeVie { get; set; }

    public int Armure { get; set; }

    public int Degats { get; set; }

    public DateTime DateCreation { get; init; } = DateTime.Now;

    public int NombrePersonnesTuees { get; set; }

    public override string ToString()
    {
        return $"Pseudo : {Pseudo}\nPoints de vie : {PointsDeVie}\nArmure : {Armure}\nDégats : {Degats}\nNombre de personnes tuées : {NombrePersonnesTuees}\n";
    }
}