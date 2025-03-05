using System;

namespace Assignment.Contracts.Data.Entities;

public class ReportingManager : User
{
    public ICollection<Candidate>? Candidates { get; set; }
}
