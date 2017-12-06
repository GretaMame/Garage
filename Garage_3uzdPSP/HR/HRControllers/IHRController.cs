using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRControllers
{
    interface IHRController
    {
        int HireEmployee(string name, string surname);
        int GenerateWorkSheet(int id, int workedHours, decimal hourlyPay);
        decimal PaySalary(int sheetID);
    }
}
