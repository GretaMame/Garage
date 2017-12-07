using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyRepository
{
    interface IPartRepository
    {
        int AddPart(IPart part);
        IPart GetPart(int id);
    }
}
