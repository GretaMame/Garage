using Garage_3uzdPSP.GarageService.GarageServiceFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceControllers
{
    class GarageServiceController : IGarageServiceController
    {
        IGarageServiceFacade facade;

        public GarageServiceController(IGarageServiceFacade facade)
        {
            this.facade = facade;
        }
        public int AddCustomer(string name, string surname)
        {
            return facade.AddCustomer(name, surname);
        }

        public int AddGarageService(string name, decimal price)
        {
            return facade.AddGarageService(name, price);
        }

        public int ProvideService(int custID, int serviceID)
        {
            return facade.ProvideGarageService(custID, serviceID);
        }
    }
}
