using System;

namespace Assignment.Contracts.Data.Entities;

public class TAAdmin : Users
{
public ICollection<Interview> ?ManagedInterviews { get; set; }
}
