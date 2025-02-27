using Exercice02.Models;
using Exercice02.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercice02.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PizzaController(PizzaService pizzaService) : ControllerBase
{
    [HttpGet("menu")]
    public async Task<IActionResult> Menu()
    {
        var pizzas = await pizzaService.GetAll();

        return Ok(pizzas);
    }

    [HttpPost("pizza")]
    public async Task<IActionResult> CreatePizza([FromBody] Pizza pizza)
    {
        await pizzaService.CreatePizza(pizza);

        return Ok(pizza);
    }

    [HttpPut("pizza/add-topping/{pizzaId}")]
    public async Task<IActionResult> AddTopping()
    {
        throw new NotImplementedException();
    }
}
