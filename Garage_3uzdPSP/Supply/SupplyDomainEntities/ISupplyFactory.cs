using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    interface ISupplyFactory
    {
        ISupplier CreateSupplier(string name);
        IPart CreatePart(string partNo, string manufacturer, ISupplier supplier);
    }
}
