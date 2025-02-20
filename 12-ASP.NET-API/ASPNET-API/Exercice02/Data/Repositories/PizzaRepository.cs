using Exercice02.Abstractions;
using Exercice02.Models;

namespace Exercice02.Data.Repositories;

public class PizzaRepository(AppDbContext context) : IRepository<Pizza>
{
    public async Task<Pizza?> Get(Guid id)
    {
        return await context.Pizzas.FindAsync(id);
    }

    public async Task<IEnumerable<Pizza>> Get(Func<Pizza, bool> predicate)
    {
        return context.Pizzas.Where(predicate);
    }

    public async Task<IEnumerable<Pizza>> GetAll()
    {
        return context.Pizzas;
    }

    public async Task Add(Pizza entity)
    {
        await context.Pizzas.AddAsync(entity);
    }

    public async Task Update(Pizza entity)
    {
        var pizzaFromDb = await context.Pizzas.FindAsync(entity.Id);
        if (pizzaFromDb is null) throw new ArgumentNullException();

        if (pizzaFromDb.Name != entity.Name)
            pizzaFromDb.Name = entity.Name;
        if (pizzaFromDb.Description != entity.Description)
            pizzaFromDb.Description = entity.Description;

        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var pizza = await context.Pizzas.FindAsync(id);
        if (pizza is null) throw new ArgumentNullException();

        context.Pizzas.Remove(pizza);
        await context.SaveChangesAsync();
    }
}