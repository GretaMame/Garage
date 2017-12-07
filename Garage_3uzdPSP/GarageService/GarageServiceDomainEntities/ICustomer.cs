﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    interface ICustomer
    {
        string Name { get; }
        string Surname { get; }
        List<IGarageService> GarageServicesProvided { get; set; }
        bool IsEmployee();
    }
}
