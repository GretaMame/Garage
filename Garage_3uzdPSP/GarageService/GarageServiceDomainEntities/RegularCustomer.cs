using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class RegularCustomer : ICustomer
    {
        public string Name { get; }

        public string Surname { get; }

        public List<IGarageService> GarageServicesProvided { get; set; }

        public RegularCustomer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public bool IsEmployee()
        {
            return false;
        }
    }
}
