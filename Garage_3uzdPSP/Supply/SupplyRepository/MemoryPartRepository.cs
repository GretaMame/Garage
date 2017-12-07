using Garage_3uzdPSP.Supply.SupplyDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.Supply.SupplyRepository
{
    class MemoryPartRepository : IPartRepository
    {
        Dictionary<int, IPart> parts;
        int id = 0;

        public MemoryPartRepository()
        {
            parts = new Dictionary<int, IPart>();
        }

        public int AddPart(IPart part)
        {
            parts.Add(id, part);
            int partId = id;
            id++;
            Debug.WriteLine("Saved " + part.GetType().ToString() + " to memory repo");
            return partId;
        }

        public IPart GetPart(int id)
        {
            if (parts.ContainsKey(id))
            {
                Debug.WriteLine("Part with key " + id + " found in memory repo.");
                return parts[id];
            }
            else
            {
                Debug.WriteLine("Part with key " + id + " not found in memory repo");
                return null;
            }
        }
    }
}
