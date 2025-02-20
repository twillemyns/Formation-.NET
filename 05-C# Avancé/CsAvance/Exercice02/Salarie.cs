namespace Exercice02;

public class Salarie
{
    public string Matricule { get; set; }

    public string Service { get; set; }

    public string Categorie { get; set; }

    public string Name { get; set; }

    public double Salaire { get; set; }

    public Salarie()
    {
        NbSalaries++;
    }

    public Salarie(string matricule, string service, string categorie, string name, double salaire)
    {
        Matricule = matricule;
        Service = service;
        Categorie = categorie;
        Name = name;
        Salaire = salaire;

        NbSalaries++;
        SalaireTotal += salaire;
    }

    public void AfficherSalaire()
        => Console.WriteLine(this);

    public static int NbSalaries;

    public static double SalaireTotal;

    public static void Recap()
    {
        Console.WriteLine($"Le montant total des salaires des {NbSalaries} employés est de {SalaireTotal} Euros.");
        NbSalaries = 0;
    }

    public override string ToString()
    {
        return $"Le salaire de {Name} est de {Salaire} euros";
    }
}
