using Exercice01.Abstractions;
using Exercice01.Models;
using Exercice01.Models.DTO;

namespace Exercice01.Services;

public class ContactService(IRepository<Contact> repository) : IContactService
{
    public IEnumerable<ContactDto> GetAll()
    {
        return repository.GetAll().Select(ToViewModel);
    }

    public ContactDto Get(Guid id)
    {
        var contact = repository.Get(id);
        if (contact is null)
            throw new ArgumentNullException(nameof(contact), "Contact non trouvé");

        return ToViewModel(contact);
    }

    public ContactDto Get(Func<Contact, bool> predicate)
    {
        var contact = repository.Get(predicate).FirstOrDefault();

        if (contact is null)
            throw new ArgumentNullException(nameof(contact), "Contact non trouvé");

        return ToViewModel(contact);
    }

    public ContactDto Add(ContactCreateDto vm)
    {
        var contact = ToContact(vm);
        repository.Add(contact);

        return ToViewModel(contact);
    }

    public void Delete(Guid id)
    {
        repository.Delete(id);
    }

    private Contact ToContact(ContactCreateDto vm)
    {
        return new Contact
        {
            FirstName = vm.FirstName,
            LastName = vm.LastName,
            BirthDate = vm.BirthDate,
            Email = vm.Email,
            Genre = vm.Genre,
            PhoneNumber = vm.PhoneNumber
        };
    }

    private ContactDto ToViewModel(Contact contact)
    {
        var today = DateOnly.FromDateTime(DateTime.Today);
        var age = today.Year - contact.BirthDate.Year;

        if (contact.BirthDate > today.AddYears(-age)) age--;

        return new ContactDto
        {
            Id = contact.Id,
            FullName = $"{contact.FirstName} {contact.LastName}",
            Age = age,
            Email = contact.Email,
            Genre = contact.Genre,
            PhoneNumber = contact.PhoneNumber
        };
    }
}