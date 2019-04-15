using Demo_Polymorphism_Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = IntializeEmployees();
            DisplayPayroll(employees);
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
                    ISalary regularPayEmployee = employee as ISalary;
                    Console.WriteLine(String.Format($"Regular Pay: {regularPayEmployee.CalculateRegularPay():c}"));
                }
                if (employee is IHourly)
                {
                    string hourType;

                    if (employee is FullTime)
                    {
                        hourType = "Overtime";
                    }
                    else
                    {
                        hourType = "Regular";
                    }

                    IHourly hourlyPayEmployee = employee as IHourly;
                    Console.Write($"Enter {hourType} Hours: ");
                    double.TryParse(Console.ReadLine(), out double hours);
                    Console.WriteLine(String.Format($"{hourType} Pay: {hourlyPayEmployee.CalculateHourlyPay(hours):c}"));
                }

                Console.WriteLine("\n\n");
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
                    Id = 2,
                    LastName = "Velis",
                    FirstName = "Jeff",
                    HourlyWage = 15.5
                }
            };
        }
    }
}
