using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    interface ISalary
    {
        double AnnualSalary { get; set; }

        double RegularPay();
    }
}
