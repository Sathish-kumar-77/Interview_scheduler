using System;

namespace Assignment.Contracts.Data.Entities;

public class TAAdmin : User
{
public ICollection<Interview> ?ManagedInterviews { get; set; }
}
