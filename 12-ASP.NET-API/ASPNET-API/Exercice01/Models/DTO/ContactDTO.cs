using System.ComponentModel.DataAnnotations;

namespace Exercice01.Models.DTO;

public class ContactDto
{
    public Guid Id { get; set; }
    
    public string FullName { get; set; }
    
    public int Age { get; set; }

    [RegularExpression("^[MFN]$")]
    public required char Genre { get; set; }
    
    [EmailAddress]
    [StringLength(50)]
    public string? Email { get; set; }
    
    [Phone]
    [StringLength(10)]
    public string? PhoneNumber { get; set; }
}