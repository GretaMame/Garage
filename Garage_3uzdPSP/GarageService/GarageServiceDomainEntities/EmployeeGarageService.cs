using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class EmployeeGarageService : IGarageService
    {
        public string Name { get; }
        public decimal Price { private get; set; }

        public EmployeeGarageService(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetPrice()
        {
            return Price - 0.25m * Price;
        }
    }
}
