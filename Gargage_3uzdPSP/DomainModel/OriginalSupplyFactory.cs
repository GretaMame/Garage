using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargage_3uzdPSP.DomainModel
{
    class OriginalSupplyFactory : ISupplyFactory
    {
        public OriginalSupplyFactory()
        {
        }

        public IPart createPart()
        {
            throw new NotImplementedException();
        }

        public ISupplier createSupplier()
        {
            throw new NotImplementedException();
        }
    }
}
