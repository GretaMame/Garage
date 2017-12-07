using Garage_3uzdPSP.HR.HRControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.HR.HRUI
{
    class ConsoleHRUI
    {
        IHRController controller;

        public ConsoleHRUI(IHRController cntrl)
        {
            controller = cntrl;
        }

        public void RegisterEmployee()
        {
            Console.WriteLine("--EMPLOYEE REGISTRATION--");
            Console.WriteLine("Please enter employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter employee surname:");
            string surname = Console.ReadLine();
            int id = controller.HireEmployee(name, surname);
            Console.WriteLine("Employee "+name+" "+ surname+" successfully added with ID "+id);
        }

        public void GenerateWorkSheet()
        {
            Console.WriteLine("--NEW WORKSHEET GENERATION--");
            Console.WriteLine("Please enter employee id:");
            int id;
            while(!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter correct ID");
            }
            Console.WriteLine("Please enter hours worked:");
            int hours;
            while (!Int32.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Please enter correct amount of hours");
            }
            Console.WriteLine("Please enter hourly pay:");
            decimal pay;
            while (!Decimal.TryParse(Console.ReadLine(), out pay))
            {
                Console.WriteLine("Please enter correct pay");
            }

            int workSheetID = controller.GenerateWorkSheet(id, hours, pay);
            Console.WriteLine("Woksheet successfully added with ID " + workSheetID);
        }

        public void PaySalary()
        {
            Console.WriteLine("--SALARY PAYMENT--");
            Console.WriteLine("Please enter sheet id:");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter correct ID");
            }
            decimal amount = controller.PaySalary(id);
            Console.WriteLine("Sheet with ID " + id + " successfully paid. Amount: "+amount);
        }
    }
}
