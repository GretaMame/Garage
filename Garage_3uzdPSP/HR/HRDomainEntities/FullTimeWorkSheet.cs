using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    class FullTimeWorkSheet : IWorkSheet
    {
        public IEmployee employee { get; }

        public DateTime WorkSheetDate { get; }

        public int HoursWorked { get; private set; }

        public decimal HourlyPay { get; private set; }

        public FullTimeWorkSheet(IEmployee employee, DateTime date, decimal pay, int hours)
        {
            this.employee = employee;
            WorkSheetDate = date;
            HoursWorked = hours;
            HourlyPay = pay;

        }
        public bool AddHours(int hours)
        {
             return false;
        }

        public void ChangeFixedHours(int hours)
        {
            HoursWorked = hours;
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
            return true;
        }

        public void changeSalary(decimal amount)
        {
            HourlyPay = (decimal) amount / HoursWorked;
        }

        public decimal getSalary()
        {
            return HoursWorked * HourlyPay;
        }

    }
}
