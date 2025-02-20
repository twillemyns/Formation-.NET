using Exercice04.Data;
using Exercice04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice04.Controllers;

public class MarmosetController(FakeDb db) : Controller
{
    public IActionResult Index()
    {
        return View(db.Marmosets);
    }

    public IActionResult Details(int id)
    {
        var marmoset = db.Marmosets.First(m => m.Id == id);

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
            Id = db.Marmosets.Max(m => m.Id) + 1,
            Name = RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ", number),
            Age = number
        };

        db.Marmosets.Add(marmoset);

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
        var marmoset = db.Marmosets.First(m => m.Id == id);

        db.Marmosets.Remove(marmoset);

        return RedirectToAction(nameof(Index));
    }
}