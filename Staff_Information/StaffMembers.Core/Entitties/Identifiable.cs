using System;
using System.Collections.Generic;
using System.Text;

namespace StaffMembers.Core.Entitties
{
    class Identifiable
    {
        public Guid Id { get; }

        protected Identifiable(Guid? id = null)
        {
            Id = (id == null) ? Guid.NewGuid() : id.Value;
        }
    }
}
