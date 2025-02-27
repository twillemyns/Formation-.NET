using Exercice02.Abstractions;
using Exercice02.Models;

namespace Exercice02.Services;

public class PizzaService(IRepository<Pizza> pizzaRepository, IRepository<Ingredient> ingredientRepository)
{
    // Liste des pizzas
    public async Task<IEnumerable<Pizza>> GetAll()
    {
        return await pizzaRepository.GetAll();
    }

    // Liste pizzas avec filtre
    public async Task<IEnumerable<Pizza>> GetPizzas(string name, params Ingredient[] ingredients)
    {
        return await pizzaRepository.GetAll(p => 
            p.Name == name && p.Ingredients.Any(
                i => ingredients
                    .Select(ingredient => ingredient.Id)
                    .Contains(i.Id))
            );
    }

    // Création pizza
    public async Task CreatePizza(Pizza pizza, params Ingredient[] ingredients)
    {
        pizza.Ingredients = ingredients;

        await pizzaRepository.Add(pizza);
    }

    // Création ingrédient
    public async Task CreateIngredient(Ingredient ingredient, Pizza? pizza = null)
    {
        if (pizza != null)
            ingredient.Pizzas.Append(pizza);

        await ingredientRepository.Add(ingredient);
    }

    // Modif pizza
    public async Task UpdatePizza(Guid idPizza, string name, string description)
    {
        await pizzaRepository.Update(new Pizza()
        {
            Id = idPizza,
            Name = name,
            Description = description,
        });
    }

    // Ajout ingrédient à pizza
    public async Task AddIngredientToPizza(Guid ingredientId, Guid pizzaId)
    {
        var pizza = await pizzaRepository.Get(pizzaId);
        if (pizza is null) throw new ArgumentNullException(pizzaId.ToString(), "Pizza non trouvée");

        var ingredient = await ingredientRepository.Get(ingredientId);
        if (ingredient is null) throw new ArgumentNullException(ingredientId.ToString(), "Ingrédient non trouvé");

        pizza.Ingredients.Append(ingredient);

        await pizzaRepository.Update(pizza);
    }

    // Suppression pizza
    public async Task DeletePizza(Guid pizzaId)
    {
        await pizzaRepository.Delete(pizzaId);
    }

    // Suppression ingrédient à pizza
    public async Task RemoveIngredientToPizza(Guid ingredientId, Guid pizzaId)
    {
        var pizza = await pizzaRepository.Get(pizzaId);
        if (pizza is null) throw new ArgumentNullException(pizzaId.ToString(), "Pizza non trouvée");

        var ingredient = await ingredientRepository.Get(ingredientId);
        if (ingredient is null) throw new ArgumentNullException(ingredientId.ToString(), "Ingrédient non trouvé");

        if (!pizza.Ingredients.Contains(ingredient))
            throw new ArgumentNullException(nameof(ingredient), "Ingrédient déjà absent de la pizza");

        pizza.Ingredients.ToList().Remove(ingredient);

        await pizzaRepository.Update(pizza);
    }
}