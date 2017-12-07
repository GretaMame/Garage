using Garage_3uzdPSP.HR.HRDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRRepository
{
    interface IWorkSheetRepository
    {
        int AddWorkSheet(IWorkSheet workSheet);
        IWorkSheet GetWorkSheet(int id);
    }
}
