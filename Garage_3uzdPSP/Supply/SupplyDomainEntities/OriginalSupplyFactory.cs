using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class OriginalSupplyFactory : ISupplyFactory
    {
        public IPart CreatePart(string partNo, string manufacturer, ISupplier supplier)
        {
            Debug.WriteLine("Creating part from " + this.GetType().ToString());
            return new OriginalPart(partNo, manufacturer, supplier);
        }

        public ISupplier CreateSupplier(string name, string email)
        {
            Debug.WriteLine("Creating supplier from " + this.GetType().ToString());
            return new OriginalSupplier(name, email);
        }
    }
}
