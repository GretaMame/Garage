using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class AfterMarketSupplyFactory : ISupplyFactory
    {
        public IPart CreatePart(string partNo, string manufacturer, ISupplier supplier)
        {
            return new AfterMarketPart(partNo, manufacturer, supplier);
        }

        public ISupplier CreateSupplier(string name, string email)
        {
            return new AfterMarketSupplier(name, email);
        }
    }
}
