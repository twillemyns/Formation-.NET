namespace Exercice07_CompteBancaire;

public class Client
{
    public int Id { get; set; }
    
    public string Nom { get; set; }
    
    public string Prenom { get; set; }
    
    public List<CompteBancaire> ComptesBancaires { get; set; }
    
    public string Telephone { get; set; }
}