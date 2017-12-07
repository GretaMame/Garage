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

        public string Email { get; }

        public List<IGarageService> GarageServicesProvided { get; set; }

        public RegularCustomer(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
            GarageServicesProvided = new List<IGarageService>();
        }

        public bool IsEmployee()
        {
            return false;
        }
    }
}
