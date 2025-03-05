using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class Users
{

    [Key]
    public Guid UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string ?Name { get; set; }

    [Required]
    [MaxLength(150)]
    public string ?Email { get; set; }

    [Required]
    [MaxLength(255)]
    public string ?PasswordHash { get; set; }

   
    

    [ForeignKey("Role")]
    public int RoleId { get; set; } 
    public Role ?Role { get; set; } 

}
