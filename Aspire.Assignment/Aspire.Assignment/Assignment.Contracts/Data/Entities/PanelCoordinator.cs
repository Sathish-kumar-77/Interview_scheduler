using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class PanelCoordinator
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [ForeignKey("Users")]
    public Guid UserId { get; set; }
    public Users users {get; set;}
    
 public ICollection<PanelMember> PanelMembers { get; set; } = new List<PanelMember>();

}
