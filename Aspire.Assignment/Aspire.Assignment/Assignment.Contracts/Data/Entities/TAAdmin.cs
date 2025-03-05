using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class TAAdmin 
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public Users? Users { get; set; }
public ICollection<Interview> ?ManagedInterviews { get; set; }
}
