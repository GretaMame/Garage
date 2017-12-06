using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class FullTimeEmployee : IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        public DateTime DateOfEmployment { get; }

        public FullTimeEmployee(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfEmployment = DateTime.Today;
        }

        public bool GetsBenefits()
        {
            return true;
        }
    }
}
