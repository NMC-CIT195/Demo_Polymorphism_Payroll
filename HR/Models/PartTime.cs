using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    class PartTime : Employee, IHourly
    {
        public double HourlyWage { get; set; }

        public double GrossHourlyPay(double hours)
        {
            return hours * HourlyWage;
        }
    }
}
