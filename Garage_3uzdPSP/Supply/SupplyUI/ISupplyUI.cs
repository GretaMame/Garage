using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyUI
{
    interface ISupplyUI
    {
        void RegisterSupplier();
        void RegisterPart();
        void EvaluateOrderingRisk();
    }
}
