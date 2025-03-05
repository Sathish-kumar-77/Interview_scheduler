using System;

namespace Assignment.Contracts.Data.Entities;

public class ReportingManager : Users
{
    public ICollection<Candidate>? Candidates { get; set; }
}
