namespace Exercice08_Figure;

public class Point(double posX, double posY)
{
    public double PosX { get; set; } = posX;

    public double PosY { get; set; } = posY;

    public override string ToString()
    {
        return $"{PosX:N2};{PosY:N2}";
    }
}