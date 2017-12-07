using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceRepository
{
    interface IGarageServiceRepository
    {
        int AddGarageService(IGarageService service);
        IGarageService GetGarageService(int id); 
    }
}
