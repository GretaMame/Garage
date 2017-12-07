using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_3uzdPSP.HR.HRDomainEntities;

namespace Garage_3uzdPSP.HR.HRDomainServices
{
    class HolidayBonus : IBenefitsProvider
    {
        public decimal Amount { get; set; }

        public HolidayBonus(decimal amount)
        {
            Amount = amount;
        }
        public decimal GetBenefitPrice(IEmployee employee)
        {
            if (employee.GetsBenefits())
            {
                return Amount;
            }
            else return Amount * 0.25m;
        }
    }
}
