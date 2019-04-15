using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    class FullTime : Employee, ISalary, IHourly
    {
        public bool HealthBenefits;
        public bool RetirementBenefits;

        public double AnnualSalary { get; set; }
        public double HourlyWage { get; set; }

        public double GrossHourlyPay(double hours)
        {
            return hours * HourlyWage;
        }

        public double GrossSalaryPay()
        {
            return AnnualSalary / 26;
        }
    }
}
