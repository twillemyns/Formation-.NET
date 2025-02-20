//Ex01
string displayName(string nom, string prenom) => prenom + " " + nom;

//Ex02
int sub(int nb1, int nb2)
{
    Console.WriteLine($"Je soustrais {nb1} et {nb2}.");
    return nb1 - nb2;
}

//Ex03
void quelle_heure(string heure = "12h00") => Console.WriteLine($"Il est {heure}");

//Ex04
int compter_lettre_a(string phrase)
{
    var a = 0;
    foreach (var c in phrase)
        if (c == 'a')
            a++;

    return a;
}

int compter_lettre_a_bis(string phrase) => phrase.Count(c => c == 'a');

Console.WriteLine(sub(3, 2));