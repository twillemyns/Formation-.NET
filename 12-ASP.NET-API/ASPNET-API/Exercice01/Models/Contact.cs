using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercice01.Models;

public class Contact
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [RegularExpression("^[A-Za-zÀ-ÖØ-öø-ÿ]*")]
    [StringLength(50)]
    public required string FirstName { get; set; }
    
    [RegularExpression("^[A-Za-zÀ-ÖØ-öø-ÿ ]*")]
    [StringLength(50)]
    public required string LastName { get; set; }
    
    [Range(typeof(DateOnly), "1910-01-01", "2025-02-18")]
    public DateOnly BirthDate { get; set; }

    [RegularExpression("^[MFN]$")]
    public required char Genre { get; set; }
    
    [EmailAddress]
    [StringLength(50)]
    public string? Email { get; set; }
    
    [Phone]
    [StringLength(10)]
    public string? PhoneNumber { get; set; }
}