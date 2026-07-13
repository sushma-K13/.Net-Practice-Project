using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Services
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public void AddEmployee(Employee employee)
        {
            Console.WriteLine("Employee added successfully.");
        }

        public void DisplayEmployee(Employee employee)
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Employee Id   : {employee.Id}");
            Console.WriteLine($"Name          : {employee.Name}");
            Console.WriteLine($"Department    : {employee.Department}");
            Console.WriteLine($"Employee Type : {employee.EmployeeType}");
            Console.WriteLine($"Basic Salary  : {employee.BasicSalary}");
            Console.WriteLine($"Email         : {employee.Email}");
        }
    }
}
