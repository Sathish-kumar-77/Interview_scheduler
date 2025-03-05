using System;

namespace Assignment.Contracts.Data.Entities;


using System.Collections.Generic;

public class TARecruiter : Users
{
    public ICollection<Interview>? ScheduledInterviews { get; set; }
}


