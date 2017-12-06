using Garage_3uzdPSP.HR.HRDomainEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRRepository
{
    class MemoryEmployeeRepository : IEmployeeRepository
    {
        Dictionary<int, IEmployee> employees;
        static int id = 0;

        public MemoryEmployeeRepository()
        {
            employees = new Dictionary<int, IEmployee>();
        }

        public int AddEmployee(IEmployee emp)
        {
            employees.Add(id, emp);
            int empId = id;
            id++;
            Debug.WriteLine("Saved "+ emp.GetType().ToString() +" to memory repo");
            return empId;
        }

        public IEmployee GetEmployee(int id)
        {
            if (employees.ContainsKey(id))
            {
                Debug.WriteLine("Employee with key "+id+" found in memory repo.");
                return employees[id];
            }
            else
            {
                Debug.WriteLine("Employee with key "+id+" not found in memory repo");
                return null;
            }
        }
    }
}
