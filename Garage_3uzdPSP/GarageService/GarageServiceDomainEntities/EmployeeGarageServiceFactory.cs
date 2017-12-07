using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class EmployeeGarageServiceFactory : IGarageServiceFactory
    {
        public ICustomer CreateCustomer(string name, string surname, string email)
        {
            Debug.WriteLine("Creating customer from " + this.GetType().ToString());
            return new EmployeeCustomer(name, surname, email);
        }

        public IGarageService CreateService(string name, decimal price)
        {
            Debug.WriteLine("Creating garage service from " + this.GetType().ToString());
            return new EmployeeGarageService(name, price);
        }
    }
}
