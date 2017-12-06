using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class PartTimeEmployee : IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        public DateTime BirthDate { get; }

        public DateTime DateOfEmployment { get; }

        public PartTimeEmployee(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            BirthDate = dateOfBirth;
            DateOfEmployment = DateTime.Today;
        }

        public bool GetsBenefits()
        {
            return false;
        }
    }
}
