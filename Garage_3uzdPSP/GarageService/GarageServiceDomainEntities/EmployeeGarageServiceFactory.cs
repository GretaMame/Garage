using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class EmployeeGarageServiceFactory : IGarageServiceFactory
    {
        public ICustomer CreateCustomer(string name, string surname, string email)
        {
            return new EmployeeCustomer(name, surname, email);
        }

        public IGarageService CreateService(string name, decimal price)
        {
            return new EmployeeGarageService(name, price);
        }
    }
}
