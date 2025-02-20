using Microsoft.AspNetCore.Mvc;

namespace Exercice01.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public string AfficherTous()
    {
        return "J'affiche tous les contacts";
    }

    public string AfficherUnSeul(int id)
    {
        return "J'affiche un seul contact";
    }

    public string AjouterUn()
    {
        return "J'ajoute un contact";
    }
}
