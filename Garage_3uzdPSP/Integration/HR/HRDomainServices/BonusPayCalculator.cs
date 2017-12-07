using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_3uzdPSP.HR.HRDomainEntities;

namespace Garage_3uzdPSP.HR.HRDomainServices
{
    class BonusPayCalculator : IPayCalculator
    {

        public decimal calculatePay(IWorkSheet workSheet)
        {
            return workSheet.HourlyPay * workSheet.HoursWorked + 200;
        }
    }
}
