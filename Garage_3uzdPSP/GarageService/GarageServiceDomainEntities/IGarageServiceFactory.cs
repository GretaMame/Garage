using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    interface IGarageServiceFactory
    {
        ICustomer CreateCustomer(string name, string surname, string email);
        IGarageService CreateService(string name, decimal price);
    }
}
