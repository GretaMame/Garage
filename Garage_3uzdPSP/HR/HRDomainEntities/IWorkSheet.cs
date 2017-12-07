using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_3uzdPSP.HR.HRDomainEntities
{
    interface IWorkSheet
    {
        IEmployee employee { get; }
        DateTime WorkSheetDate { get; }
        int HoursWorked { get; }
        decimal HourlyPay { get;}

        bool AddHours(int hours);
        void IncreaseHourlyPay(decimal amount);
        void DecreaseHourlyPay(decimal amount);
        bool EntitledToBonus();

    }
}
