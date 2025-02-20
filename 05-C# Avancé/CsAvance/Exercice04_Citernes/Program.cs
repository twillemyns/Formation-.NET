using Exercice04_Citernes;

var liste = new List<WaterTank>
{
    new WaterTank(1000, 500, 0.5),
    new WaterTank(2000, 1500, 0.8),
    new WaterTank(3000, 750, 0.3)
};

foreach (var item in liste)
{
    Console.WriteLine($"Poids total: {item.GetTotalWeight()} kg");
    Console.WriteLine($"Quantité d'eau dans le réservoir: {item.CurrentWaterWeight}");
    Console.WriteLine($"Remplissage de 100kg:");
    item.FillTank(100);
    Console.WriteLine($"Quantité d'eau dans le réservoir: {item.CurrentWaterWeight}");
    Console.WriteLine($"Vidage de 150kg:");
    item.DrainTank(150);
    Console.WriteLine($"Quantité d'eau dans le réservoir: {item.CurrentWaterWeight}");
    Console.WriteLine("-----------------------------------------------------------------");
}

Console.WriteLine($"Quantité totale d'eau: {WaterTank.TotalWaterQuantity}");