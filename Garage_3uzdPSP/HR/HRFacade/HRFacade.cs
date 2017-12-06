using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRFacade
{
    interface HRFacade
    {
        int registerEmployee(string name, string surname, DateTime dateOfEmployment);
        int generateWorkseet(int employerID, int hoursWorked, decimal hourlyRate);
        decimal paySalary(int worksheetID);
    }
}
