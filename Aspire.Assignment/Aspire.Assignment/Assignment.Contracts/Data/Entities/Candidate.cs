using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class Candidate 
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public Users? Users { get; set; }


    [ForeignKey("ReportingManager")]
    public Guid ReportingManagerId { get; set; }
    
    public ReportingManager ?ReportingManager {get; set;}
    
    
    

    public ICollection<Interview>? Interviews { get; set; }
}

