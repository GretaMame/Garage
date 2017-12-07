using Garage_3uzdPSP.GarageService.GarageServiceDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.GarageService.GarageServiceRepository
{
    class MemoryCustomerRepository : ICustomerRepository
    {
        Dictionary<int, ICustomer> customers;
        static int id = 0;

        public MemoryCustomerRepository()
        {
            customers = new Dictionary<int, ICustomer>();
        }

        public int AddCustomer(ICustomer cust)
        {
            customers.Add(id, cust);
            int custId = id;
            id++;
            Debug.WriteLine("Saved " + cust.GetType().ToString() + " to memory repo");
            return custId;
        }

        public ICustomer GetCustomer(int id)
        {
            if (customers.ContainsKey(id))
            {
                Debug.WriteLine("Customer with key " + id + " found in memory repo.");
                return customers[id];
            }
            else
            {
                Debug.WriteLine("Customer with key " + id + " not found in memory repo");
                return null;
            }
        }
    }
}
