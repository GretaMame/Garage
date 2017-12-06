using Garage_3uzdPSP.HR.HRDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRRepository
{
    class MemoryWorkSheetRepository : IWorkSheetRepository
    {
        int id = 0;
        Dictionary<int, IWorkSheet> workSheets;

        public MemoryWorkSheetRepository()
        {
            workSheets = new Dictionary<int, IWorkSheet>();
        }

        public int AddWorkSheet(IWorkSheet workSheet)
        {
            workSheets.Add(id, workSheet);
            int workSheetId = id;
            id++;
            Debug.WriteLine("Saved " + workSheet.GetType().ToString() + " to memory repo");
            return workSheetId;
        }

        public IWorkSheet GetWorkSheet(int id)
        {
            if (workSheets.ContainsKey(id))
            {
                Debug.WriteLine("Worksheet with key " + id + " found in memory repo.");
                return workSheets[id];
            }
            else
            {
                Debug.WriteLine("Worksheet with key " + id + " not found in memory repo");
                return null;
            }
        }
    }
}
