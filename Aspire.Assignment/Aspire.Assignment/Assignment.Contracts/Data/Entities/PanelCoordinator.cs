using System;

namespace Assignment.Contracts.Data.Entities;

public class PanelCoordinator : Users
{

 public ICollection<PanelMember> PanelMembers { get; set; } = new List<PanelMember>();

}
