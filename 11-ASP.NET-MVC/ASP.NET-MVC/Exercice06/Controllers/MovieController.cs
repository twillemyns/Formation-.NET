using Exercice06.Data;
using Exercice06.Models;
using Exercice06.Models.ViewModels;
using Exercice06.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exercice06.Controllers;

public class MovieController(IMovieService service) : Controller
{
    // GET
    public IActionResult Index()
    {
        var movies = service.GetAll().ToList();
        return View(movies);
    }

    public IActionResult Create()
    {
        ViewBag.FormMode = "Create";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(
        [Bind("Name", "ReleaseDate", "IsWatched", "File")]
        MovieCreateViewModel movie
        )
    {
        if (!ModelState.IsValid)
        {
            ViewBag.FormMode = "Create";
            return View("Form", movie);
        }

        service.Create(movie);

        return RedirectToAction(nameof(Index));
    }

    // public IActionResult Edit(int id)
    // {
    //     var movie = service.GetById(id);
    //     if (movie is null)
    //     {
    //         return View("Error", new ErrorViewModel() { RequestId = "404" });
    //     }
    //     
    //     var createViewMovie = service.
    //
    //     ViewBag.FormMode = "Edit";
    //     return View("Form", movie);
    // }
    //
    // [HttpPost]
    // public IActionResult Edit(Movie movie)
    // {
    //     if (!ModelState.IsValid)
    //     {
    //         ViewBag.FormMode = "Edit";
    //         return View("Form", movie);
    //     }
    //     
    //     repository.Update(movie);
    //
    //     return RedirectToAction(nameof(Index));
    // }
}