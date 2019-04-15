using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphism_Payroll.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string lastName, string firstName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }

        public virtual string ListOfBenifits()
        {
            return "Contact HR for more information.";
        }
    }
}
