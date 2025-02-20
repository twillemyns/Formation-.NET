using Exercice01.Models;
using Exercice01.Models.DTO;

namespace Exercice01.Abstractions;

public interface IContactService
{
    ContactDto? Get(Guid id);

    ContactDto? Get(Func<Contact, bool> predicate);

    IEnumerable<ContactDto> GetAll();

    ContactDto Add(ContactCreateDto vm);

    void Delete(Guid id);
}