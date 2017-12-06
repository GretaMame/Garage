using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class PartTimeWorkSheet : IWorkSheet
    {
        public IEmployee employee { get; }

        public DateTime WorkSheetDate { get; }

        public int HoursWorked { get; private set; }

        public decimal HourlyPay { get; private set; }

        public PartTimeWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours)
        {
            this.employee = employee;
            WorkSheetDate = date;
            HourlyPay = pay;
            HoursWorked = hours;
        }

        public bool AddHours(int hours)
        {
            HoursWorked += hours;
            return true;
        }

        public void DecreaseHourlyPay(decimal amount)
        {
            HourlyPay -= amount;
        }

        public void IncreaseHourlyPay(decimal amount)
        {
            HourlyPay += amount;
        }

        public bool EntitledToBonus()
        {
            return false;
        }
    }
}
