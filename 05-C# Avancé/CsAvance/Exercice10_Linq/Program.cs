using Person = (int Id, string Name, int Age, string City);

var people = new List<Person>
{
    (1, "Alice", 25, "Paris"),
    (2, "Bob", 30, "Lyon"),
    (3, "Charlie", 35, "Marseille"),
    (4, "Diana", 40, "Paris"),
    (5, "Eve", 28, "Lyon"),
    (6, "Frank", 33, "Paris")
};

// 1 Trouver toutes les personnes de Paris.
var paris = people.Where(p => p.City == "Paris").ToList();
var parisbis = from p in people
                where p.City == "Paris"
                select p;

// 2 Trouver les noms des personnes ayant plus de 30 ans.
var vieux = people.Where(p => p.Age > 30).ToList();
var vieuxbis = from p in people where p.Age > 30 select p;

// 3 Trier les personnes par âge croissant.
var croissant = people.OrderBy(p => p.Age).ToList();

// 4 Compter le nombre de personnes vivant à Lyon.
var nbLions = people.Count(p => p.City == "Lyon");

// 5 Trouver la personne la plus âgée.
var tresVieux = people.OrderBy(p => p.Age).Last();

// 6 Obtenir une liste des villes distinctes.
var villes = people.Select(p => p.City)
    .Distinct()
    .ToList();

// 7 Vérifier si toutes les personnes ont plus de 20 ans.
var isAdultes = people.All(p => p.Age > 20);

// 8 Projeter une nouvelle liste contenant uniquement les noms et âges.
var nomsAges = people.Select(p => new { p.Name, p.Age }).ToList();

// 9 Trouver le nom de la personne la plus jeune vivant à Paris.
var jeuneParis = people
    .Where(p => p.City == "Paris")
    .OrderBy(p => p.Age)
    .First()
    .Name;

// 10 Grouper les personnes par ville et afficher le nombre de personnes dans chaque ville.
var groupeVille = people.GroupBy(p => p.City).Select(x =>
{
    Console.WriteLine($"{x.Key} : {x.Count()}");
    return x;
});

// 11 Créer une séquence infinie de nombres pairs et récupérer les 10 premiers.
var pairs = Enumerable.Range(0, int.MaxValue).Where(x => x % 2 == 0).Take(10);

// 12 Paginer une liste de nombres de 1 à 100 pour obtenir le 3ème bloc de 10 nombres (21 à 30).
var nbPage = 2;
var bloc = Enumerable.Range(0, 100)
    .Skip(10 * nbPage)
    .Take(10 * (nbPage + 1));

// 13 Trouver le nombre maximum dans une liste d'entiers. [4, 8, 15, 16, 23, 42]
int[] nombres = [4, 8, 15, 16, 23, 42];
var maximum = nombres.Max();

// 14 Filtrer les mots d'une liste contenant plus de 5 lettres. ["chat", "ordinateur", "table", "lampe", "programme"]
string[] mots = ["chat", "ordinateur", "table", "lampe", "programme"];
var longsMots = mots.Where(s => s.Length > 5);