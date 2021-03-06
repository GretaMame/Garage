﻿using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainServices
{
    interface IGarageServiceProvider
    {
        int WaitingTimeInDays { get; set; }
        void ProvideGarageService(ICustomer customer, IGarageService service);
    }
}
