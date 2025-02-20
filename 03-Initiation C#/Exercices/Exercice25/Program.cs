int choix;
var notes = new List<float>();
do
{
    menu();

    switch (choix)
    {
        case 1:
            choix1();
            break;
        case 2:
            choix2();
            break;
        case 3:
            choix3();
            break;
        case 4:
            choix4();
            break;
        default:
            break;
    }
}
while (choix != 0);

void choix1()
{
    float note;
    int nbNote = 1;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ Saisir les notes ------\n" +
                      "(999 pour stopper la saisie)\n");
    Console.ForegroundColor= ConsoleColor.White;

    do
    {
        do
        {
            Console.Write($"Veuillez saisir la note {nbNote} (/20) : ");
            note = float.Parse(Console.ReadLine()!);
            if (note != 999)
            {
                if (note > 20)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    notes.Add(note);
            }
        }
        while (note > 20 && note != 999);
        nbNote++;
    }
    while (note != 999);
    Console.Clear();
}

void choix2()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ La plus grande note ------\n");
    Console.WriteLine($"La note la plus grande est : {notes.Max()}/20\n");
    Console.ForegroundColor = ConsoleColor.White;
}

void choix3()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("------ La plus petite note ------\n");
    Console.WriteLine($"La note la plus grande est : {notes.Min()}/20\n");
    Console.ForegroundColor = ConsoleColor.White;
}

void choix4()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("------ La moyenne des notes ------\n");
    Console.WriteLine($"La moyenne est de : {notes.Average():N1}/20\n");
    Console.ForegroundColor = ConsoleColor.White;
}

void menu()
{
    Console.WriteLine("--- Gestion des notes avec menu ---\n");

    Console.WriteLine("1----Saisir les notes\n" +
                      "2----La plus grande note\n" +
                      "3----La plus petite note\n" +
                      "4----La moyenne des notes\n" +
                      "0----Quitter");

    Console.WriteLine("Faites votre choix :");
    choix = int.Parse(Console.ReadLine()!);

    Console.Clear();
}