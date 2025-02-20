using Exercice05.Data;
using Exercice05.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice05.Controllers;

public class MarmosetController(MarmosetRepository repository) : Controller
{
    public IActionResult Index()
    {
        return View(repository.GetAll().ToHashSet());
    }

    public IActionResult Details(int id)
    {
        var marmoset = repository.Get(id);

        return View(marmoset);
    }

    public IActionResult CreateRandom()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create()
    {
        var rdm = new Random();
        var number = rdm.Next(1, 10);
        var marmoset = new Marmoset()
        {
            Name = RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", number),
            Age = number
        };

        repository.Add(marmoset);

        return RedirectToAction(nameof(Index));
    }

    private static string RandomString(string chars, int length)
    {
        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public IActionResult Delete(int id)
    {
        var marmoset = repository.Get(id);

        repository.Delete(marmoset!);

        return RedirectToAction(nameof(Index));
    }
}