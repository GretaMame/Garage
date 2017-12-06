using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRFacade
{
    interface IHRFacade
    {
        int RegisterEmployee(string name, string surname);
        int GenerateWorkseet(int employerID, int hoursWorked, decimal hourlyPay);
        decimal CalculateSalary(int worksheetID);
    }
}
