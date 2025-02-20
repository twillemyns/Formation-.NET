namespace Exercice08_Figure;

public class Rectangle(Point origine, double longueur, double largeur) : Figure(origine)
{
    public double Longueur { get; set; } = longueur;

    public double Largeur { get; set; } = largeur;
    
    public Point B => new(Origine.PosX + Longueur, Origine.PosY);
    
    public Point C => new(Origine.PosX + Longueur, Origine.PosY - Largeur);
    
    public Point D => new(Origine.PosX, Origine.PosY - Largeur);

    public override string ToString()
    {
        return $"Coordonnées du rectangle ABCD (Longueur = {Longueur}, Largur = {Longueur}):\n" +
               $"A = {Origine}\n" +
               $"B = {B}\n" +
               $"C = {C}\n" +
               $"D = {D}\n";
    }
}