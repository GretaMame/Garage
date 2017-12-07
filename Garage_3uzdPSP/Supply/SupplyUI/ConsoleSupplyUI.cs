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
            int id = controller.RegisterSupplier(name);
            Console.WriteLine("Supplier " + name + "  successfully added with ID " + id);
        }

        public void RegisterPart()
        {

        }

    }
}
