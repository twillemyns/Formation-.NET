bool verification_adn(string chaine) => chaine.All(c => "atcg".Contains(c));

string saisie_adn(string nomChaine)
{
    string chaine;

    do
    {
        Console.WriteLine($"Veuillez saisir une {nomChaine} :");
        chaine = Console.ReadLine()!;

        if (!verification_adn(chaine))
            Console.WriteLine($"{nomChaine} invalide. Veuillez réessayer.");
    } while (!verification_adn(chaine));

    return chaine;
}

float proportion(string chaine, string sequence)
{
    int nbRepetitions = 0;
    char[] test = new char[sequence.Length];

    for (var i = 0; i < chaine.Length - sequence.Length; i++)
    {
        chaine.CopyTo(i, test, 0, sequence.Length);
        if (sequence.SequenceEqual(test)) nbRepetitions++;
    }

    return ((float)(nbRepetitions * sequence.Length) / chaine.Length)*100;
}

// var chaine =
//     "gcatcgtcgatgcagaatgcatcgatgatagcatcgatcgtgatagatcgatcgaagtcagtagcatggtacgctagtagctagccatgtacagattagcatgctagc";
// var sequence = "cgtcg";

var chaine = saisie_adn("chaine");
var sequence = saisie_adn("séquence");

Console.WriteLine(proportion(chaine, sequence).ToString("N2") + "%");