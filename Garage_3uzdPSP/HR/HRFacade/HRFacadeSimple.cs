using Garage_3uzdPSP.HR.HRDomainEntities;
using Garage_3uzdPSP.HR.HRRepository;
using Garage_3uzdPSP.HR.HRDomainServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRFacade
{
    class HRFacadeSimple : IHRFacade
    {
        IEmployeeRepository employeeRepository;
        IWorkSheetRepository workSheetRepository;
        IHRFactory factory;
        IPayCalculator payCalculator;

        public HRFacadeSimple(IEmployeeRepository employeeRepository, IWorkSheetRepository workSheetRepository,
            IHRFactory factory, IPayCalculator payCalculator)
        {
            this.employeeRepository = employeeRepository;
            this.workSheetRepository = workSheetRepository;
            this.factory = factory;
            this.payCalculator = payCalculator;

        }
        public int GenerateWorkseet(int employeeID, int hoursWorked, decimal hourlyRate)
        {
            Debug.WriteLine("Looking for employee with id " + employeeID + " in repo from facade");
            IEmployee employee = employeeRepository.GetEmployee(employeeID);
            if (employee == null)
            {
                Console.WriteLine("Employee with entered ID not found");
                return -1;
            }
            IWorkSheet worksheet = factory.CreateWorkSheet(employee, DateTime.Today, hourlyRate, hoursWorked);
            int id = workSheetRepository.AddWorkSheet(worksheet);
            Debug.WriteLine("Worksheet with ID "+ id + " added to repo from facade");
            return id;
        }

        public decimal CalculateSalary(int worksheetID)
        {
            Debug.WriteLine("Looking for worksheet with id "+ worksheetID + " in repo from facade");
            IWorkSheet worksheet = workSheetRepository.GetWorkSheet(worksheetID);
            if(worksheet == null)
            {
                Console.WriteLine("Worksheet with entered ID not found");
                return -1m;
            }
            return payCalculator.CalculatePay(worksheet);
        }

        public int RegisterEmployee(string name, string surname, string email)
        {
            IEmployee employee = factory.CreateEmployee(name, surname, email);
            int id = employeeRepository.AddEmployee(employee);
            Debug.WriteLine("Employee with ID " + id + " added to repo from facade");
            return id;
        }
    }
}
