using Demo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers;

public class ContactController : Controller
{
    private List<Contact> contacts =
    [
        new()
        {
            Id = 1,
            FirstName = "toto",
            LastName = "toto",
            Email = "toto@toto.to"
        },
        new()
        {
            Id = 2,
            FirstName = "tata",
            LastName = "tata",
            Email = "tata@tata.ta"
        },
        new()
        {
            Id = 3,
            FirstName = "titi",
            LastName = "titi",
            Email = "titi@titi.ti"
        },
        new()
        {
            Id = 4,
            FirstName = "tutu",
            LastName = "tutu",
            Email = "tutu@tutu.tu"
        },
        new()
        {
            Id = 5,
            FirstName = "tete",
            LastName = "tete",
            Email = "tete@tete.te"
        }
    ];
    
    public IActionResult Index()
    {
        return View(contacts);
    }

    public IActionResult Details(int id)
    {
        var contact = contacts.Find(c => c.Id == id);
        return View(contact);
    }

    public IActionResult Add()
    {
        return View();
    }
}
