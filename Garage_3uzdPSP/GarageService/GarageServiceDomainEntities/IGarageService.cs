﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    interface IGarageService
    {
        string Name { get; }
        decimal Price { set; }
        decimal GetPrice();
    }
}
