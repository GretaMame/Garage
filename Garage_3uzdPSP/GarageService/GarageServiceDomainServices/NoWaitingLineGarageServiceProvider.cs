using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceDomainServices
{
    class NoWaitingLineGarageServiceProvider : IGarageServiceProvider
    {
        public int WaitingTimeInDays { get; set; }

        public void ProvideGarageService(ICustomer customer, IGarageService service)
        {
            if (customer.IsEmployee())
            {
                WaitingTimeInDays = 0;
                List<IGarageService> servicesList = customer.GarageServicesProvided;
                servicesList.Add(service);
                customer.GarageServicesProvided = servicesList;
                Debug.WriteLine(service.GetType().ToString() + " was provided to " + 
                    customer.GetType().ToString()+" after "+ WaitingTimeInDays +" days.");
            }
        }
    }
}
