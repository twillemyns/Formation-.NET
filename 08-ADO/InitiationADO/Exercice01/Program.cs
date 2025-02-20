using Exercice01;

int choix;

do
{
    Console.WriteLine("1. Afficher tous les étudiants");
    Console.WriteLine("2. Afficher les étudiants d'une classe");
    Console.WriteLine("3. Supprimer un étudiant");
    Console.WriteLine("0. Quitter");

    Console.Write("Veuillez choisir : ");
    choix = int.Parse(Console.ReadLine()!);
    switch (choix)
    {
        case 1:
            Choix1();
            break;
        case 2:
            Choix2();
            break;
        case 3:
            Choix3();
            break;
    }
}
while (choix != 0);

void Choix1()
{
    Etudiant.GetEtudiants().ForEach(Console.WriteLine);
}

void Choix2()
{
    Console.Write("Entrez le numéro de la classe : ");
    var classNumber = int.Parse(Console.ReadLine()!);

    var classStudents = Etudiant.GetEtudiants(classNumber);

    classStudents.ForEach(Console.WriteLine);
}

void Choix3()
{
    Etudiant.GetEtudiants().ForEach(Console.WriteLine);

    Console.Write("Entrez l'ID de l'étudiant à supprimer : ");
    var id = int.Parse(Console.ReadLine()!);

    Etudiant.Delete(id);

}