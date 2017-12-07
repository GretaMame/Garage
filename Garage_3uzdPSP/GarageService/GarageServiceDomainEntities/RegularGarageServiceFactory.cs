﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class RegularGarageServiceFactory : IGarageServiceFactory
    {
        public ICustomer CreateCustomer(string name, string surname, string email)
        {
            return new RegularCustomer(name, surname, email);
        }

        public IGarageService CreateService(string name, decimal price)
        {
            return new RegularGarageService(name, price);
        }
    }
}
