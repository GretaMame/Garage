using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainEntities
{
    class EmployeeCustomer : ICustomer
    {
        public string Name { get; }

        public string Surname { get; }

        public List<IGarageService> GarageServicesProvided { get; set; }

        public EmployeeCustomer(string name, string surname)
        {
            Name = name;
            Surname = surname;
            GarageServicesProvided = new List<IGarageService>();
        }

        public bool IsEmployee()
        {
            return true;
        }
    }
}
