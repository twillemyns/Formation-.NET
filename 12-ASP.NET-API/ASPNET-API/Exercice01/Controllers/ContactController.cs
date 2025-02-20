using Exercice01.Abstractions;
using Exercice01.Models;
using Exercice01.Models.DTO;
using Exercice01.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exercice01.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController(IContactService service) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var contacts = service.GetAll();

        return Ok(contacts);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var contact = service.Get(id);

        return Ok(contact);
    }

    [HttpGet("search/{name}")]
    public IActionResult GetByName(string name)
    {
        var contact = service.Get(c => c.FirstName == name);

        return Ok(contact);
    }

    [HttpGet("search")]
    public IActionResult GetByParams(
        [FromQuery] string firstname,
        [FromQuery] string lastname,
        [FromQuery] string phoneNumber,
        [FromQuery] string email)
    {
        var contacts = service.GetAll();
        
            contacts = contacts.Where(c => c.FullName.Contains(firstname));
            contacts = contacts.Where(c => c.FullName.Contains(lastname));
            contacts = contacts.Where(c => c.PhoneNumber.Contains(phoneNumber));
            contacts = contacts.Where(c => c.Email.Contains(email));
        
        return Ok(contacts.ToList());
    }

    [HttpPost]
    public IActionResult Create(ContactCreateDto dto)
    {
        var contactDto = service.Add(dto);

        return CreatedAtAction(nameof(GetById), new { id = contactDto.Id }, "Contact créé.");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        service.Delete(id);

        return Ok();
    }
}