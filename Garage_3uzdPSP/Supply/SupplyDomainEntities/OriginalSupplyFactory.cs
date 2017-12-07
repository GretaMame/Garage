using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class OriginalSupplyFactory : ISupplyFactory
    {
        public OriginalSupplyFactory()
        {
        }

        public IPart createPart(string partNo, string manufacturer, ISupplier supplier)
        {
            return new OriginalPart(partNo, manufacturer, supplier);
        }

        public ISupplier createSupplier()
        {
            throw new NotImplementedException();
        }
    }
}
