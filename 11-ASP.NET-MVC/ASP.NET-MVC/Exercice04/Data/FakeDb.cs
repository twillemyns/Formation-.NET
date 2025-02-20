using Exercice04.Models;

namespace Exercice04.Data;

public class FakeDb
{
    public HashSet<Marmoset> Marmosets =
    [
        new() { Id = 1, Name = "Momo", Age = 8 },
        new() { Id = 2, Name = "Mimi", Age = 2 }
    ];
}