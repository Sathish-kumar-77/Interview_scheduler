using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class Slot
{
     [Key]
    public Guid SlotId { get; set; }

    [Required]
    [ForeignKey("PanelMemberId")]
    public Guid  PanelMemberId{ get; set; }
    
    public PanelMember ?PanelMember { get; set; }

   [Required]
    public DateTime Date{get;set;}

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    public bool IsBooked { get; set; } = false;

}
