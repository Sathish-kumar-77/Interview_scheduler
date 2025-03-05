using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Contracts.Data.Entities;

public class PanelMember : Users
{



    [Required]
    [MaxLength(100)]
    public string ? Skill { get; set; }

    [Required]
    public int Experience { get; set; }

    [Required]
    [MaxLength(10)]
    public string ?InterviewLevel { get; set; } 

    public ICollection<Slot>? Slots { get; set; }

    public DateTime AllocatedStartDate { get; set; } 
    public DateTime AllocatedEndDate { get; set; }
}


