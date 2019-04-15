using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    interface IHourly
    {
        double HourlyWage { get; set; }

        double GrossHourlyPay(double hours);
    }
}
