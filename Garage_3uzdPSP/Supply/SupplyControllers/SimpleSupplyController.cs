using Garage_3uzdPSP.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyControllers
{
    class SimpleSupplyController : ISupplyController
    {
        ISupplyFacade facade;

        public SimpleSupplyController(ISupplyFacade fsd)
        {
            facade = fsd;
        }

        public int EvaluateOrderRisk(int partID)
        {
            return facade.EvaluteRisk(partID);
        }

        public int RegisterPart(string partNo, string manufacturer, int supplierID)
        {
            return facade.AddPart(supplierID, partNo, manufacturer);
        }

        public int RegisterSupplier(string name)
        {
            return facade.AddSupplier(name);
        }
    }
}
