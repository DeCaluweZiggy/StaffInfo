using StaffMembers.Core.Entitties;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffMembers.Core.Interfaces
{
    public interface IPerson
    {
        public Guid Id { get; }

        bool IsUnique(IEnumerable<IPerson> inCollection, out IPerson matchingCollectable);

        bool changeAdress(Adress newAdress);

       void changeAccountNumber(string newNumber);
       

    }
}
