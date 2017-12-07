using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceControllers
{
    interface IGarageServiceController
    {
        int AddGarageService(string name, decimal price);
        int AddCustomer(string name, string surname);
        int ProvideService(int custID, int serviceID);
    }
}
