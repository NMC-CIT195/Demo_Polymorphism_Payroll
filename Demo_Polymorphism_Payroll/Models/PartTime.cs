using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class PartTime : Employee, IHourly, IOvertime
    {
        public double HourlyWage { get; set; }

        public double CalculateRegularHourlyPay(double hours)
        {
            return hours * HourlyWage;
        }

        public double CalculateOvertimePay(double overtimeHours)
        {
            return overtimeHours * (HourlyWage * 1.5);
        }


    }
}
