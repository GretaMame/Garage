using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Garage_3uzdPSP.Supply.SupplyDomainServices
{
    class BigAmountOrderRiskRateEvaluator : IOrderingRiskEvaluator
    {
        int riskRate;
        public BigAmountOrderRiskRateEvaluator()
        {
            riskRate = 6;
        }

        public int EvaluateOrderingRiskRate(IPart part)
        {
            if (part.Supplier.IsReliable())
            {
                riskRate -= 2;
            }
            else riskRate += 3;
            return riskRate;
        }
    }
}
