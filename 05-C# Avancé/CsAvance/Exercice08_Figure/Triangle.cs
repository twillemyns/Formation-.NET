namespace Exercice08_Figure;

public class Triangle(Point origine, double @base, double hauteur) : Figure(origine)
{
    public double Base { get; set; } = @base;

    public double Hauteur { get; set; } = hauteur;
    
    public Point B => new(Origine.PosX - Hauteur, Origine.PosY + Base / 2);
    
    public Point C => new(Origine.PosX - Hauteur, Origine.PosY - Base / 2);

    public override string ToString()
    {
        return $"Coordonnées du triangle ABC (Base = {Base}, Hauteur = {Hauteur}):\n" +
               $"A = {Origine}\n" +
               $"B = {B}\n" +
               $"C = {C}\n";
    }
}