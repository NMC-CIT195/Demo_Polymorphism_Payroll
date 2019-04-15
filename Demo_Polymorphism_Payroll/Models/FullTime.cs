﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class FullTime : Employee, ISalary, IHourly
    {
        public bool HealthBenefits;
        public bool RetirementBenefits;

        public double AnnualSalary { get; set; }
        public double HourlyWage { get; set; }

        public double CalculateHourlyPay(double hours)
        {
            return hours * HourlyWage;
        }

        public double CalculateRegularPay()
        {
            return AnnualSalary / 26;
        }
    }
}