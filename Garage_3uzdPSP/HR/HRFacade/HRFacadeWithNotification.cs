using Garage_3uzdPSP.HR.HRDomainEntities;
using Garage_3uzdPSP.HR.HRRepository;
using Gargage_3uzdPSP.HR.HRDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRFacade
{
    class HRFacadeWithNotification : IHRFacade
    {
        IEmployeeRepository employeeRepository;
        IWorkSheetRepository workSheetRepository;
        IHRFactory factory;
        IPayCalculator payCalculator;

        public HRFacadeWithNotification(IEmployeeRepository employeeRepository, IWorkSheetRepository workSheetRepository,
            IHRFactory factory, IPayCalculator payCalculator)
        {
            this.employeeRepository = employeeRepository;
            this.workSheetRepository = workSheetRepository;
            this.factory = factory;
            this.payCalculator = payCalculator;

        }
        public int GenerateWorkseet(int employeeID, int hoursWorked, decimal hourlyRate)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateSalary(int worksheetID)
        {
            throw new NotImplementedException();
        }

        public int RegisterEmployee(string name, string surname)
        {
            throw new NotImplementedException();
        }
    }
}
