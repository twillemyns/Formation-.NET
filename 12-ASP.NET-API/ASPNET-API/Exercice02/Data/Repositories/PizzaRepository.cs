using System.Linq.Expressions;
using Exercice02.Abstractions;
using Exercice02.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02.Data.Repositories;

public class PizzaRepository(AppDbContext context) : IRepository<Pizza>
{
    public async Task<Pizza?> Get(Guid id)
    {
        return await context.Pizzas.FindAsync(id);
    }

    public async Task<Pizza?> Get(Expression<Func<Pizza, bool>> predicate)
    {
        return await context.Pizzas.FirstOrDefaultAsync(predicate);
    }

    public async Task<IEnumerable<Pizza>> GetAll(Func<Pizza, bool> predicate)
    {
        return context.Pizzas.Where(predicate);
    }

    public async Task<IEnumerable<Pizza>> GetAll()
    {
        return context.Pizzas;
    }

    public async Task<bool> Any(Expression<Func<Pizza, bool>> predicate)
    {
        return await context.Pizzas.AnyAsync(predicate);
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