using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    interface ISalary
    {
        double AnnualSalary { get; set; }

        double CalculateRegularPay();
    }
}
