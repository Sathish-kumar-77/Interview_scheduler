using System;

namespace Assignment.Contracts.Data.Entities;

public class PanelCoordinator : User
{

 public ICollection<PanelMember> PanelMembers { get; set; } = new List<PanelMember>();

}
