using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.DomainModel
{
    interface ISupplyFactory
    {
        ISupplier createSupplier();
        IPart createPart();
    }
}
