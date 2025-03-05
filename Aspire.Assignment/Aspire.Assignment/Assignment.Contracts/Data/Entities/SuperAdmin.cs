using System;

namespace Assignment.Contracts.Data.Entities;

public class SuperAdmin : Users
{
    public ICollection<User> ManagedUsers { get; set; } = new List<User>();
}
