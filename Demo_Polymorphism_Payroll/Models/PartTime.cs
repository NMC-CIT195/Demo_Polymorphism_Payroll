using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class PartTime : Employee, IHourly
    {
        public double HourlyWage { get; set; }

        public double CalculateHourlyPay(double hours)
        {
            return hours * HourlyWage;
        }
    }
}
