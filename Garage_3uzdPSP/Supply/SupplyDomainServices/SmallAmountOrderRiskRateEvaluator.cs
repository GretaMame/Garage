using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.Supply.SupplyDomainServices
{
    class SmallAmountOrderRiskRateEvaluator : IOrderingRiskEvaluator
    {
        int rate;
        public SmallAmountOrderRiskRateEvaluator()
        {
            rate = 5;
        }
        public int EvaluateOrderingRiskRate(IPart part)
        {
            if (part.Supplier.IsReliable())
            {
                rate -= 3;
            }
            else rate += 3;
            return rate;
        }
        
    }
}
