namespace Exercice07_CompteBancaire;

public class Operation
{
    public int Numero { get; set; }
    
    public double Montant { get; set; }
    
    public Statut Statut { get; set; }
}

public enum Statut
{
    Depot,
    Retrait
}