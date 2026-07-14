using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Models
{
    public class Employee
    {
        // Unique Employee Id
        public int Id { get; set; }

        // Employee Name
        public string Name { get; set; }

        // Employee Type
        // Example: Permanent, Contract, Intern
        public string EmployeeType { get; set; }

        // Basic Salary of Employee
        public double BasicSalary { get; set; }

        // Department Name
        public string Department { get; set; }

        // Employee Email Address
        public string Email { get; set; }
    }
}
