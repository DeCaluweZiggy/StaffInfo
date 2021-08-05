using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace StaffMembers.Core.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; }

        string FirtName { get; }

        string LastName { get;}

        string Adress { get; }

        string AccountNumber { get; }

        int HoursAWeek { get; set; }

        Contract Contract { get; set; }
        int OverTime { get; set; }
    }
}
