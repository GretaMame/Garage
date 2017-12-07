using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainServices
{
    interface IOrderingRiskEvaluator
    {
        int EvaluateOrderingRiskRate(IPart part);
    }
}
