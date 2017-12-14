using Garage_3uzdPSP.HR.HRDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainServices
{
    interface IPayCalculator
    {
        decimal CalculatePay(IWorkSheet worksheet);
    }
}
