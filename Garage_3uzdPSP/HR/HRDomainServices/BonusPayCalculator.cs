using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_3uzdPSP.HR.HRDomainEntities;
using System.Diagnostics;
using Unity.Attributes;

namespace Garage_3uzdPSP.HR.HRDomainServices
{
    class BonusPayCalculator : IPayCalculator
    {
        public decimal CalculatePay(IWorkSheet workSheet)
        {
            Debug.WriteLine("Calculating salary with" + this.GetType().ToString());
            return workSheet.HourlyPay * workSheet.HoursWorked + 200;
        }
    }
}
