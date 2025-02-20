// Ex2
Console.WriteLine("Veuillez saisir votre prénom:");
var prenom = Console.ReadLine();

// Ex3
Console.WriteLine("Veuillez saisir votre nom:");
var nom = Console.ReadLine();

// Ex4
Console.WriteLine("Veulliez saisir votre âge :");
var age = Console.ReadLine();

Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans.");

//Ex5
Console.WriteLine("Choisissez un nombre:");
var nb1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Choisissez un 2e nombre:");
var nb2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"La somme est de :{nb1 + nb2}");