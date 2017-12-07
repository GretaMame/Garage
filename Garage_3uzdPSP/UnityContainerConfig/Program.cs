using Gargage_3uzdPSP.GarageService.GarageServiceUI;
using Gargage_3uzdPSP.HR.HRUI;
using Gargage_3uzdPSP.Supply.SupplyUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.UnityContainerConfig
{
    class Program
    {
        ConsoleGarageServiceUI garageUI;
        ConsoleHRUI hrUI;
        ConsoleSupplyUI supplyUI;
        static void Main(string[] args)
        {
            int choice = displayMenu();
            switch(choice)
            {
                case 1:
                    hrUI.RegisterEmployee();
                    break;
                case 2:
                    hrUI.GenerateWorkSheet();
                    break;
                case 3:
                    hrUI.PaySalary();
                    break;
                case 4:
                    supplyUI.RegisterSupplier();
                    break;
                case 5:
                    supplyUI.RegisterPart();
                    break;
                case 6:
                    supplyUI.EvaluateOrderingRisk();
                    break;
                case 7:
                    garageUI.RegisterCustomer();
                    break;
                case 8:
                    garageUI.RegisterGarageService();
                    break;
                case 9:
                    garageUI.ProvideService();
                    break;
                case 10:
                    Environment.Exit(0);
                    break;
            }
           
        }

        static int displayMenu()
        {
            Console.WriteLine("--MENU--");
            Console.WriteLine("1. Register new employee");
            Console.WriteLine("2. Submit  worksheet");
            Console.WriteLine("3. Pay salary");
            Console.WriteLine("4. Register new supplier");
            Console.WriteLine("5. Order part");
            Console.WriteLine("6. Evaluate part ordering risk");
            Console.WriteLine("7. Register new customer");
            Console.WriteLine("8. Add new garage service");
            Console.WriteLine("9. Provide garage service");
            Console.WriteLine("10. Exit program");
            Console.WriteLine("\nPlease enter menu selction number:");
            int selection;
            while(!Int32.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Please enter valid selection");
                Console.ReadLine();
            }
            return selection;
        }
    }
}
