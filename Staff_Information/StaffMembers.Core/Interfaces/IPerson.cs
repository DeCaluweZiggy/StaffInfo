using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace StaffMembers.Core.Interfaces
{
    public interface IPerson
    {    
        string FirtName { get; set; }
        string LastName { get; set; }
        string Adress { get; set; }
        string AccountNumber { get; set}
        int HoursAWeek { get; set; }
        Contract Contract { get; set; }
        int OverTime { get; }
    }
}
