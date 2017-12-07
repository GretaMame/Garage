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

        public string Email { get; }

        public DateTime DateOfEmployment { get; }

        public PartTimeEmployee(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
            DateOfEmployment = DateTime.Today;
        }

        public bool GetsBenefits()
        {
            return false;
        }
    }
}
