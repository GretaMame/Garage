using Garage_3uzdPSP.HR.HRDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.HR.HRDomainServices
{
    class BussinesTripProvider : IBenefitsProvider
    {
        public decimal Price { get; set; }

        public BussinesTripProvider(decimal price)
        {
            Price = price;
        }
        public decimal GetBenefitPrice(IEmployee employee)
        {
            if (employee.GetsBenefits())
            {
                return 0;
            }
            else return Price;
        }
    }
}
