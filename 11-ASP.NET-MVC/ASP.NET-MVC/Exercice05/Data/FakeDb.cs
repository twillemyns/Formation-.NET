using Exercice05.Models;

namespace Exercice05.Data;

public class FakeDb
{
    public HashSet<Marmoset> Marmosets =
    [
        new() { Id = 1, Name = "Momo", Age = 8 },
        new() { Id = 2, Name = "Mimi", Age = 2 }
    ];
}