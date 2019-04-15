using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    interface IHourly
    {
        double HourlyWage { get; set; }

        double CalculateHourlyPay(double hours);
    }
}
