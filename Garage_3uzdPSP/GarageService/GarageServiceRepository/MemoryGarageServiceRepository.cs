using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.GarageService.GarageServiceRepository
{
    class MemoryGarageServiceRepository : IGarageServiceRepository
    {
        Dictionary<int, IGarageService> services;
        static int id = 0;

        public MemoryGarageServiceRepository()
        {
            services = new Dictionary<int, IGarageService>();
        }

        public int AddGarageService(IGarageService service)
        {
            services.Add(id, service);
            int serviceId = id;
            id++;
            Debug.WriteLine("Saved " + service.GetType().ToString() + " to memory repo");
            return serviceId;
        }

        public IGarageService GetGarageService(int id)
        {
            if (services.ContainsKey(id))
            {
                Debug.WriteLine("Garage service with key " + id + " found in memory repo.");
                return services[id];
            }
            else
            {
                Debug.WriteLine("Garage service with key " + id + " not found in memory repo");
                return null;
            }
        }
    }
}
