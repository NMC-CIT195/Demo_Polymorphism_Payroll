using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    interface IOvertime
    {
        double CalculateOvertimePay(double overtimeHours);
    }
}
