using System;
using System.Collections.Generic;
using System.Text;

namespace StaffMembers.Core.Interfaces
{
    interface IPersonDataSource
    {
        IEnumerable<IPerson> Collectables { get; }

        public bool Remove(IPerson toRemove);

        public void Insert(IPerson toInsert);
    }
}
