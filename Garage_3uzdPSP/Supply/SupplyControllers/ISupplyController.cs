using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyControllers
{
    interface ISupplyController
    {
        int RegisterSupplier(string name);
        int RegisterPart(string partNo, string manufacturer, int supplierID);
        int EvaluateOrderingRisk(int partID);
    }
}
