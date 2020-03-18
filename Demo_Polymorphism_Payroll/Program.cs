using Demo_Polymorphism_Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll
{
    /// <summary>
    /// demonstration of polymophism using inheritance and interfaces
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = IntializeEmployees();
            DisplayPayroll(employees);
        }

        static void DisplayPayroll(List<Employee> employees)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\tEmployee Payroll");
            Console.WriteLine();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"\tID: {employee.Id}");
                Console.WriteLine($"\tLast Name: {employee.LastName}");
                Console.WriteLine($"\tFirst Name: {employee.FirstName}");

                Console.WriteLine("\t*************      Benefits    ***************");
                Console.WriteLine(DisplayBennifits(employee));
                Console.WriteLine("\t**********************************************");

                Console.WriteLine();
                
                Console.WriteLine("\t***********      Regular Pay     *************");
                DisplayRegularPay(employee);
                Console.WriteLine("\t**********************************************");

                Console.WriteLine();

                Console.WriteLine("\t***********     Overtime Pay     *************");
                DisplayRegularPay(employee);
                Console.WriteLine("\t**********************************************");



                Console.WriteLine("\n\n");
            }

            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
        }

        static void DisplayOvertimePay(Employee employee)
        {
            double hours;

            Console.Write("\tOvertime hours:");
            hours = Convert.ToDouble(Console.ReadLine()); // Note: no validation

            if (employee is PartTime)
            {
                PartTime partTimeEmployee = employee as PartTime;
                Console.WriteLine($"\tOvertime pay: {partTimeEmployee.CalculateOvertimePay(hours):c}");
            }
            else if (employee is FullTime)
            {
                FullTime fullTimeEmployee = employee as FullTime;
                Console.WriteLine($"\tOvertime Pay: {fullTimeEmployee.CalculateOvertimePay(hours):c}");
            }
        }

        static void DisplayRegularPay(Employee employee)
        {
            double hours;

            if (employee is PartTime)
            {
                PartTime partTimeEmployee = employee as PartTime;
                Console.Write("\tRegular hours:");
                hours = Convert.ToDouble(Console.ReadLine()); // Note: no validation
                Console.WriteLine($"\tRegular pay: {partTimeEmployee.CalculateRegularHourlyPay(hours):c}");
            }
            else if (employee is FullTime)
            {
                FullTime fullTimeEmployee = employee as FullTime;
                Console.WriteLine($"\tRegular Pay: {fullTimeEmployee.CalculateRegularPay():c}");
            }
        }

        static string DisplayBennifits(Employee employee)
        {
            //
            // the StringBuilder class is used to generate a string to pass
            //
            StringBuilder sb = new StringBuilder();
            sb.Clear();

            if (employee is PartTime)
            {
                sb.AppendLine("\tHealth Benefits: None");
                sb.AppendLine("\tRetirement Benefits: None");
            }
            else if (employee is FullTime)
            {
                FullTime fullTimeEmployee = employee as FullTime;
                sb.AppendLine($"\tHealth Benefits: {fullTimeEmployee.HealthBenefits}");
                sb.AppendLine($"\tRetirement Benefits: {fullTimeEmployee.RetirementBenefits}");
            }        

            return sb.ToString();
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
                    HealthBenefits = true,
                    RetirementBenefits = true
                },

                new PartTime()
                {
                    Id = 2,
                    LastName = "Velis",
                    FirstName = "Jeff",
                    HourlyWage = 15.5
                },

                new PartTime()
                {
                    Id = 3,
                    LastName = "Velis",
                    FirstName = "Sally",
                    HourlyWage = 17.75
                },

                new FullTime()
                {
                    Id = 1,
                    LastName = "Velis",
                    FirstName = "Fred",
                    AnnualSalary = 35000,
                    HealthBenefits = true,
                    RetirementBenefits = false
                },
            };
        }
    }
}
