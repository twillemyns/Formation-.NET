namespace Exercice08_Figure;

public class Carre( Point origine, double cote) : Figure(origine)
{
    public double Cote { get; set; } = cote;

    public Point B => new(Origine.PosX + Cote, Origine.PosY);
    
    public Point C => new(Origine.PosX + Cote, Origine.PosY - Cote);
    
    public Point D => new(Origine.PosX, Origine.PosY - Cote);

    public override string ToString()
    {
        return $"Coordonnées du carré ABCD (Coté = {Cote}):\n" +
               $"A = {Origine}\n" +
               $"B = {B}\n" +
               $"C = {C}\n" +
               $"D = {D}\n";
    }
}