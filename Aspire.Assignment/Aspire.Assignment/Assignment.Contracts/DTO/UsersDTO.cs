using System;

namespace Assignment.Contracts.DTO;

public class UsersDTO
{

    public Guid UserId { get; set; } = Guid.NewGuid();
    
    public string ?Name { get; set; }

    public string ?Email { get; set; }

    public string ?PasswordHash { get; set; }

    public Guid RoleId { get; set; } 
}
