namespace Exercice07_CompteBancaire;

public abstract class CompteBancaire
{
    public double Solde { get; set; }
    
    public Client Client { get; set; }
    
    public List<Operation> Operations { get; set; }

    public override string ToString()
    {
        return $"Compte : {GetType()} ; Solde : {Solde}";
    }
}