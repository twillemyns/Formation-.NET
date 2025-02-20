using System.Diagnostics;
using Demo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // /Home/DisBonjour?personne=value
        public string DisBonjour(string personne)
        {
            return $"Bonjour à toi {personne} !";
        }

        // /Home/Compter/value => RouteParameter (grace au routage par défaut dans program.cs)
        // /Home/Compter/id=value => QueryParameter
        public string Compter(int id)
        {
            return $"Compte = {id}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
