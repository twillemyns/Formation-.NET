﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercice02.Models;

public class User
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }
    
    [StringLength(50)]
    public required string FirstName { get; set; }
    
    [StringLength(50)]
    public required string LastName { get; set; }
    
    [EmailAddress]
    public required string Email { get; set; }
    
    
    public required string Password { get; set; }
    
    [Phone]
    public required string PhoneNumber { get; set; }
    
    [StringLength(100)]
    public required string Address { get; set; }
    
    public bool IsAdmin { get; set; }
}