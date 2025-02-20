namespace Exercice04_Citernes;

internal class WaterTank
{
    /// <summary>
    /// en kg
    /// </summary>
    public double EmptyWeight { get; set; }

    /// <summary>
    /// En Kg
    /// </summary>
    public double TotalCapacity { get; set; }

    /// <summary>
    /// En pourcentrage entre 0 et 1
    /// </summary>
    public double FillingLevel { get; set; }

    public static double TotalWaterQuantity;

    public double CurrentWaterWeight => TotalCapacity * FillingLevel;

    public WaterTank(double emptyWeight, double totalCapacity, double fillingLevel)
    {
        EmptyWeight = emptyWeight;
        TotalCapacity = totalCapacity;
        FillingLevel = fillingLevel;
        TotalWaterQuantity += CurrentWaterWeight;
    }

    public double GetTotalWeight()
        => EmptyWeight + CurrentWaterWeight;

    public void FillTank(double nbKilos)
    {
        TotalWaterQuantity -= CurrentWaterWeight;

        FillingLevel += nbKilos / TotalCapacity;

        if (FillingLevel > 1)
        {
            FillingLevel = 1;
            Console.WriteLine($"Le réservoir est plein !!");
        }

        TotalWaterQuantity += CurrentWaterWeight;
    }

    public void DrainTank(double nbKilos)
    {
        TotalWaterQuantity -= CurrentWaterWeight;

        FillingLevel -= nbKilos / TotalCapacity;

        if (FillingLevel < 0)
        {
            FillingLevel = 0;
            Console.WriteLine($"Le réservoir est vide !!");
        }

        TotalWaterQuantity += CurrentWaterWeight;
    }
}
