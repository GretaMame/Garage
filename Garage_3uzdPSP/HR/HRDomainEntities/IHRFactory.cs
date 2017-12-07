using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    interface IHRFactory
    {
        IEmployee CreateEmployee(string name, string surname);
        IWorkSheet CreateWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours);
    }
}
