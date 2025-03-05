using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class Candidate : Users
{
    

    [ForeignKey("ReportingManager")]
    public  Guid ReportingManagerId { get; set; }
    public ReportingManager ?ReportingManager { get; set; }

    public ICollection<Interview>? Interviews { get; set; }
}

