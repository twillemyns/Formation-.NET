using Exercice08_Figure;

var A = new Point(2, 4);
var carre = new Carre(A ,2);
var rectangle = new Rectangle(A, 3, 5);
var triangle = new Triangle(A, 4, 5);

Console.WriteLine(carre);
Console.WriteLine();
Console.WriteLine(rectangle);
Console.WriteLine();
Console.WriteLine(triangle);
carre.Deplacement(1, 3);
Console.WriteLine();
Console.WriteLine(carre);