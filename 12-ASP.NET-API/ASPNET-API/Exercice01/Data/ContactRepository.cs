using Exercice01.Abstractions;
using Exercice01.Models;

namespace Exercice01.Data;

public class ContactRepository(AppDbContext context) : IRepository<Contact>
{
    public Contact? Get(Guid id)
    {
        return context.Contacts.Find(id);
    }

    public IEnumerable<Contact> Get(Func<Contact, bool> predicate)
    {
        return context.Contacts.Where(predicate);
    }

    public IEnumerable<Contact> GetAll()
    {
        return context.Contacts;
    }

    public void Add(Contact entity)
    {
        context.Add(entity);
        context.SaveChanges();
    }

    public void Update(Contact entity)
    {
        var contactDb = context.Contacts.Find(entity.Id);
        if (contactDb is null)
            throw new ArgumentNullException(nameof(contactDb), "Contact non trouvé en BDD");

        if (entity.FirstName != contactDb.FirstName)
            contactDb.FirstName = entity.FirstName;
        if (entity.LastName != contactDb.LastName) 
            contactDb.LastName = entity.LastName;
        if (entity.BirthDate != contactDb.BirthDate) 
            contactDb.BirthDate = entity.BirthDate;
        if (entity.PhoneNumber != contactDb.PhoneNumber) 
            contactDb.PhoneNumber = entity.PhoneNumber;
        if (entity.Email != contactDb.Email) 
            contactDb.Email = entity.Email;
        if (entity.Genre != contactDb.Genre) 
            contactDb.Genre = entity.Genre;

        context.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var contact = context.Contacts.Find(id);
        if (contact is null)
            throw new ArgumentNullException(nameof(contact), "Contact non trouvé en BDD");

        context.Contacts.Remove(contact);
        context.SaveChanges();
    }
}