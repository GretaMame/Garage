using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyDomainEntities
{
    class AfterMarketSupplier : ISupplier
    {
        public string Name { get; }

        public string Email { get; }

        public AfterMarketSupplier(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public bool IsReliable()
        {
            return false;
        }
    }
}
