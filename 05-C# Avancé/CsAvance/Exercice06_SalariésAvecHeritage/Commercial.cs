using Exercice02;

namespace Exercice06_SalariésAvecHeritage;

public class Commercial : Salarie
{
    public double ChiffreAffaires { get; set; }

    public double Commission { get; set; }
    
    public double SalaireReel => Salaire + Commission * ChiffreAffaires;

    public Commercial() : base() { }

    public Commercial(string matricule,
        string service,
        string categorie,
        string name,
        double salaire,
        double chiffreAffaires,
        double commission) : base(matricule, service, categorie, name, salaire)
    {
        ChiffreAffaires = chiffreAffaires;
        Commission = commission;
    }

    public override string ToString()
        => base.ToString() + $"\nLe salaire avec commission de {Name} est de {SalaireReel:N2} euros.";
}