using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class PartTimeHRFactory : IHRFactory
    {
        public IEmployee CreateEmployee(string name, string surname, DateTime dateOfBirth)
        {
            return new PartTimeEmployee(name, surname);
        }

        public IWorkSheet CreateWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours)
        {
            return new PartTimeWorkSheet(employee, date, pay, hours);
        }
    }
}
