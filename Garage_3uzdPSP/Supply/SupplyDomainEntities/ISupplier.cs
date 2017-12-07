using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    interface ISupplier
    {
        string Name { get; }
        string Email { get; }
        bool IsReliable();

    }
}
