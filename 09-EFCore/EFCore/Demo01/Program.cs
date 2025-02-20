using Demo01.Data;
using Demo01.Models;

using var context = new ApplicationDbContext();

var book1 = new Livre
{
    Titre = "Les Misérables",
    Description = "Roman de Victor Hugo",
    Auteur = "Victor Hugo",
    DatePublication = new DateTime(1862, 1, 1)
};

var book2 = new Livre
{
    Titre = "Notre-Dame de Paris",
    Description = "Roman de Victor Hugo",
    Auteur = "Victor Hugo",
    DatePublication = new DateTime(1831, 1, 1)
};

//context.Livres.Add(book1);
//context.Livres.Add(book2);

//context.SaveChanges();

var result = context.Livres.FirstOrDefault(l => l.Titre!.Contains("Notre"));
Console.WriteLine(result?.Titre);