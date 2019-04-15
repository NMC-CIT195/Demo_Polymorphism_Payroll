using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class FullTime : Employee, ISalary, IHourly
    {
        public bool HealthBenefits { get; set; }
        public bool RetirementBenefits { get; set; }

        public double AnnualSalary { get; set; }
        public double HourlyWage { get; set; }

        public double CalculateHourlyPay(double hours)
        {
            return hours * HourlyWage * 1.5;
        }

        public double CalculateRegularPay()
        {
            return AnnualSalary / 26;
        }
    }
}
