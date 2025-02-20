using Exercice02.Abstractions;
using Exercice02.Models;

namespace Exercice02.Data.Repositories;

public class UserRepository(AppDbContext context) : IRepository<User>
{
    public async Task<User?> Get(Guid id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> Get(Func<User, bool> predicate)
    {
        return context.Users.Where(predicate);
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return context.Users;
    }

    public async Task Add(User entity)
    {
        await context.Users.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task Update(User entity)
    {
        var userFromDb = await context.Users.FindAsync(entity.Id);
        if (userFromDb is null) throw new ArgumentNullException();
        
        if (userFromDb.FirstName != entity.FirstName)
            userFromDb.FirstName = entity.FirstName;
        if (userFromDb.LastName != entity.LastName)
            userFromDb.LastName = entity.LastName;
        if (userFromDb.Address != entity.Address)
            userFromDb.Address = entity.Address;
        if (userFromDb.IsAdmin != entity.IsAdmin)
            userFromDb.IsAdmin = entity.IsAdmin;
        if (userFromDb.Email != entity.Email)
            userFromDb.Email = entity.Email;
        if (userFromDb.PhoneNumber != entity.PhoneNumber)
            userFromDb.PhoneNumber = entity.PhoneNumber;
        if (userFromDb.Password != entity.Password)
            userFromDb.Password = entity.Password;

        await context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var user = await context.Users.FindAsync(id);
        if (user is null) throw new ArgumentNullException();
        
        context.Users.Remove(user);
        await context.SaveChangesAsync();
    }
}