using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class Interview
{
    [Key]
    public Guid InterviewId { get; set; }

    [Required]
    public Guid CandidateId { get; set; }
    [ForeignKey("CandidateId")]
    public Candidate? Candidate { get; set; }

    [Required]
    public Guid PanelMemberId { get; set; }
    [ForeignKey("PanelMemberId")]
    public PanelMember? PanelMember { get; set; }

    public Guid? TARecruiterId { get; set; }
    [ForeignKey("TARecruiterId")]
    public TARecruiter? TARecruiter { get; set; }
    [Required]
    public Guid SlotId { get; set; } // Foreign Key Reference to Slot
    [ForeignKey("SlotId")]
    public Slot Slot { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime{get;set;}

    [Required]
    [MaxLength(20)]
    public string ?Status { get; set; } // Scheduled, Completed, No-Show, Rescheduled

    public bool ManagerParticipation { get; set; }

    public bool IsWithinSlotTime()
    {
        return StartTime >= Slot.StartTime && EndTime <= Slot.EndTime;
    }

}
