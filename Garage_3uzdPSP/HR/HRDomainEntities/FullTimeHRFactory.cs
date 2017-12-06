using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class FullTimeHRFactory : IHRFactory
    {
        public IEmployee CreateEmployee(string name, string surname, DateTime dateOfBirth)
        {
            return new FullTimeEmployee(name, surname);
        }

        public IWorkSheet CreateWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours)
        {
            return new FullTimeWorkSheet(employee, date, pay, hours);
        }
    }
}
