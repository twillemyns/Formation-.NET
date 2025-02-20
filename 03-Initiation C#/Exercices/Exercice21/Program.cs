Console.WriteLine("--- Accroissement de population ---\n");

int annee = 2015;
int population = 96809;
float taux = 0.89f;

while(population < 120000)
{
    population += (int) (population * (taux / 100));
    annee++;
}

Console.WriteLine($"Il faudra {annee - 2015} ans, nous serons en {annee}");
Console.WriteLine($"Il y aura {population} habitants en {annee}");