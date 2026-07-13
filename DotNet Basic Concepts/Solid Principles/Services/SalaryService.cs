using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Services
{
    internal class SalaryService : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            // Simple salary calculation
            double hra = employee.BasicSalary * 0.20;
            double da = employee.BasicSalary * 0.10;

            return employee.BasicSalary + hra + da;
        }
    }
}
