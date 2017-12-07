using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Facade
{
    interface ISupplyFacade
    {
        int AddSupplier(string name, string email);
        int AddPart(int supplierID, string partNumber,string manufacturer);
        int EvaluteRisk(int partID);
    }
}
