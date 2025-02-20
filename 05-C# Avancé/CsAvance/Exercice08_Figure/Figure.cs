namespace Exercice08_Figure;

public abstract class Figure(Point origine) : IDeplacable
{
    public Point Origine { get; set; } = origine;

    public void Deplacement(double posX, double posY)
    {
        Origine.PosX += posX;
        Origine.PosY += posY;
    }
}