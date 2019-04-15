using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = IntializeEmployees();
        }

        static void DisplayPayroll(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"First Name: {employee.FirstName}");

                if (employee is FullTime)
                {
                    FullTime fullTimeEmployee = employee as FullTime;
                    Console.WriteLine($"Health Benefits: {fullTimeEmployee.HealthBenefits}");
                    Console.WriteLine($"Retirement Benefits: {fullTimeEmployee.RetirementBenefits}");
                }
                if (employee is ISalary)
                {
                    ISalary regularPay = employee as ISalary;
                    Console.Write("Enter Overtime Hours: ");
                    double.TryParse(Console.ReadLine(), out double hours);
                    Console.WriteLine($"Regular Pay: {regularPay.GrossSalaryPay()}");
                }
                if (employee is IHourly)
                {
                    IHourly hourlyEmployee = employee as ISalary;
                    Console.Write("Enter Overtime Hours: ");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static List<Employee> IntializeEmployees()
        {
            return new List<Employee>()
            {
                new FullTime()
                {
                    Id = 1,
                    LastName = "Velis",
                    FirstName = "John",
                    AnnualSalary = 20000,
                    HourlyWage = 4.5,
                    HealthBenefits = true,
                    RetirementBenefits = true
                },

                new PartTime()
                {
                    Id = 1,
                    LastName = "Velis",
                    FirstName = "Jeff",
                    HourlyWage = 4.5
                }
            };
        }
    }
}
