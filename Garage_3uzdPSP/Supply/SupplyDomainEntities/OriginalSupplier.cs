using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class OriginalSupplier : ISupplier
    {
        public string Name { get; }

        public OriginalSupplier(string name)
        {
            Name = name;
        }

        public bool IsReliable()
        {
            return true;
        }


    }
}
