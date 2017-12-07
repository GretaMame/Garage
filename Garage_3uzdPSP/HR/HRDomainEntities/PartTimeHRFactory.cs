using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class PartTimeHRFactory : IHRFactory
    {
        public IEmployee CreateEmployee(string name, string surname, string email)
        {
            Debug.WriteLine("Creating employee from "+ this.GetType().ToString());
            return new PartTimeEmployee(name, surname, email);
        }

        public IWorkSheet CreateWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours)
        {
            Debug.WriteLine("Creating worksheet from " + this.GetType().ToString());
            return new PartTimeWorkSheet(employee, date, pay, hours);
        }
    }
}
