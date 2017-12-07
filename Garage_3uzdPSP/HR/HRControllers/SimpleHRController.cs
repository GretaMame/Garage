using Garage_3uzdPSP.HR.HRFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRControllers
{
    class SimpleHRController : IHRController
    {
        IHRFacade facade;

        public SimpleHRController(IHRFacade fsd)
        {
            facade = fsd;
        }

        public decimal PaySalary(int sheetID)
        {
            return facade.CalculateSalary(sheetID);
        }

        public int GenerateWorkSheet(int id, int workedHours, decimal hourlyPay)
        {
            return facade.GenerateWorkseet(id, workedHours, hourlyPay);
        }

        public int HireEmployee(string name, string surname, string email)
        {
            return facade.RegisterEmployee(name, surname, email);
        }
    }
}
