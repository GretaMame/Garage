using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceFacade
{
    interface IGarageServiceFacade
    {
        int AddGarageService(string name, decimal price);
        int AddCustomer(string name, string surname, string email);
        int ProvideGarageService(int custID, int serviceID);

    }
}
