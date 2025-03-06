using System;

namespace Assignment.Contracts.DTO;

public class CreateUsersDTO
{
     public Guid UserId { get; set; } = Guid.NewGuid();
    
    public string ?Name { get; set; }

    public string ?Email { get; set; }

    public string ?PasswordHash { get; set; }

    public string RoleName{ get; set; } 

}
