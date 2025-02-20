using System.ComponentModel.Design;

namespace Demo01Classes.Classes;

internal class Dinosaur
{
    private int _age;

    private string? _espece;

    private int _nbPattes;

    private double _poids;

    private bool _peutVoler;


    public int Age { get => _age; set => _age = value; }
    public string? Espece { get => _espece; set => _espece = value; }
    public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
    public double Poids
    {
        get
        {
            return _poids;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Poids invalide ! valeur de 100 ajoutée");
                _poids = 100;
            }
            else
                _poids = value;
        }
    }
    public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }
}