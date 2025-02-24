using System.ComponentModel.DataAnnotations;
using Exercice02.Helpers;
using Microsoft.IdentityModel.Logging;

namespace Exercice02.Models.DTOs;

public class RegisterRequestDTO
{
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email obligatoire")]
    public required string Email { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Mot de passe obligatoire")]
    [PasswordValidator]
    public required string Password { get; set; }

    [Required(ErrorMessage = "Prénom obligatoire")]
    public required string FirstName { get; set; }

    [Required(ErrorMessage = "Nom de famille obligatoire")]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "Numéro de téléphone obligatoire")]
    public required string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Adresse obligatoire")]
    public required string Address { get; set; }

    [Required]
    public bool IsAdmin { get; set; }
}