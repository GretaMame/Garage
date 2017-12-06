using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        DateTime BirthDate { get; }
        DateTime DateOfEmployment { get; }
        bool GetsBenefits();

    }
}
