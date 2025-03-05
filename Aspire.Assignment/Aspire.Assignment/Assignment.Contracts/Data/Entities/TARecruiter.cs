using System;

namespace Assignment.Contracts.Data.Entities;


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TARecruiter
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid UserId { get; set; }
    [ForeignKey("UserId")]
    public Users? Users { get; set; }

    public ICollection<Interview>? ScheduledInterviews { get; set; }
}


