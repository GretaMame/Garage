using Garage_3uzdPSP.Supply.SupplyControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.Supply.SupplyUI
{
    class ConsoleSupplyUI
    {
        ISupplyController controller;

        public ConsoleSupplyUI(ISupplyController cntrl)
        {
            controller = cntrl;
        }

        public void RegisterSupplier()
        {
            Console.WriteLine("--SUPPLIER REGISTRATION--");
            Console.WriteLine("Please enter supplier name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter supplier email:");
            string email = Console.ReadLine();
            int id = controller.RegisterSupplier(name, email);
            Console.WriteLine("Supplier " + name + "  successfully added with ID " + id);
        }

        public void RegisterPart()
        {
            Console.WriteLine("--PART REGISTRATION--");
            Console.WriteLine("Please enter part number:");
            string partNo = Console.ReadLine();
            Console.WriteLine("Please enter manufacturer:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Please enter supplier id:");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter correct ID");
            }
            int partID = controller.RegisterPart(partNo, manufacturer, id);
            Console.WriteLine("Part successfully added with ID " + partID);
        }

        public void EvaluateOrderingRisk()
        {
            Console.WriteLine("--ORDERING RISK EVALUATION--");
            Console.WriteLine("Please enter part id:");
            int id;
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please enter correct ID");
            }
            int risk = controller.EvaluateOrderingRisk(id);
            Console.WriteLine("Ordering part with ID "+id+"has a risk rate of "+risk);
        }

    }
}
