using Garage_3uzdPSP.GarageService.GarageServiceControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.GarageService.GarageServiceUI
{
    class GarageServiceUI
    {
        IGarageServiceController controller;

        public GarageServiceUI(IGarageServiceController cntrl)
        {
            controller = cntrl;
        }

        public void RegisterGarageService()
        {
            Console.WriteLine("--GARAGE SERVICE REGISTRATION--");
            Console.WriteLine("Please enter service name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter service price:");
            decimal price;
            while (!Decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please enter correct price");
            }
            int id = controller.AddGarageService(name, price);
            Console.WriteLine("Service " + name  + " successfully added with ID " + id);
        }

        public void RegisterCustomer()
        {
            Console.WriteLine("--NEW CUSTOMER REGISTRATION--");
            Console.WriteLine("Please enter customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter customer surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter customer email:");
            string email = Console.ReadLine();
            int id = controller.AddCustomer(name, surname, email);
            Console.WriteLine("Customer " + name + " " + surname + " successfully added with ID " + id);
        }

        public void ProvideService()
        {
            Console.WriteLine("--PROVIDE SERVICE--");
            Console.WriteLine("Please enter customer id:");
            int custID;
            while (!Int32.TryParse(Console.ReadLine(), out custID))
            {
                Console.WriteLine("Please enter correct ID");
            }
            Console.WriteLine("Please enter service id:");
            int serviceID;
            while (!Int32.TryParse(Console.ReadLine(), out serviceID))
            {
                Console.WriteLine("Please enter correct ID");
            }
            decimal amount = controller.ProvideService(custID, serviceID);
            Console.WriteLine("Service with ID " + serviceID + " provided to customer with ID " + custID);
        }
    }
}
