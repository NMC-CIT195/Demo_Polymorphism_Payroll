using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class FullTime : Employee, ISalary, IOvertime
    {
        public bool HealthBenefits { get; set; }
        public bool RetirementBenefits { get; set; }

        public double AnnualSalary { get; set; }

        public double CalculateRegularPay()
        {
            return AnnualSalary / 26;
        }

        public double CalculateOvertimePay(double overtimeHours)
        {
            //
            // divide annual salary by 2100 hours in a year to get hourly wage
            //
            return ((AnnualSalary / 2100) * 1.5) * overtimeHours;
        }
    }
}
