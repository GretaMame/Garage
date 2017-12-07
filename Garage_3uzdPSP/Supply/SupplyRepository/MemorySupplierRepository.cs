using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyRepository
{
    class MemorySupplierRepository : ISupplierRepository
    {
        Dictionary<int, ISupplier> suppliers;
        int id = 0;

        public MemorySupplierRepository()
        {
            suppliers = new Dictionary<int, ISupplier>();
        }

        public int AddSupplier(ISupplier supplier)
        {
            suppliers.Add(id, supplier);
            int supplierId = id;
            id++;
            Debug.WriteLine("Saved " + supplier.GetType().ToString() + " to memory repo");
            return supplierId;
        }

        public ISupplier GetSupplier(int id)
        {
            if (suppliers.ContainsKey(id))
            {
                Debug.WriteLine("Supplier with key " + id + " found in memory repo.");
                return suppliers[id];
            }
            else
            {
                Debug.WriteLine("Supplier with key " + id + " not found in memory repo");
                return null;
            }
        }

    }
}
