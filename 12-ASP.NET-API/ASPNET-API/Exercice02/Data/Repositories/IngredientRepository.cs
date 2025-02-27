using System.Linq.Expressions;
using Exercice02.Abstractions;
using Exercice02.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercice02.Data.Repositories;

public class IngredientRepository(AppDbContext context) : IRepository<Ingredient>
{
    public async Task<Ingredient?> Get(Guid id)
    {
        return await context.Ingredients.FindAsync(id);
    }

    public async Task<Ingredient?> Get(Expression<Func<Ingredient, bool>> predicate)
    {
        return await context.Ingredients.FirstOrDefaultAsync(predicate);
    }

    public async Task<IEnumerable<Ingredient>> GetAll(Func<Ingredient, bool> predicate)
    {
        return context.Ingredients.Where(predicate);
    }

    public async Task<IEnumerable<Ingredient>> GetAll()
    {
        return context.Ingredients;
    }

    public async Task<bool> Any(Expression<Func<Ingredient, bool>> predicate)
    {
        return await context.Ingredients.AnyAsync(predicate);
    }

    public async Task Add(Ingredient entity)
    {
        await context.Ingredients.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task Update(Ingredient entity)
    {
        var ingrediantDb = await Get(entity.Id);

        if (ingrediantDb is null)
            throw new ArgumentNullException(entity.Id.ToString(), "Ingrédiant non trouvé");

        if (ingrediantDb.Name != entity.Name)
            ingrediantDb.Name = entity.Name;
        if (ingrediantDb.Description != entity.Description)
            ingrediantDb.Description = entity.Description;

        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var ingrediant = await Get(id);

        if (ingrediant is null)
            throw new ArgumentNullException(id.ToString(), "Ingrédiant non trouvé");

        context.Remove(ingrediant);
        await context.SaveChangesAsync();
    }
}