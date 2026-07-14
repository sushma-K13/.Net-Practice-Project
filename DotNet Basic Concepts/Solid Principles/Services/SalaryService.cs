using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Services
{
    //Now SalaryService depends on an interface.
    internal class SalaryService
    {
        private readonly ISalaryCalculator _salaryCalculator;

        public SalaryService(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public double CalculateSalary(Employee employee)
        {
            return _salaryCalculator.CalculateSalary(employee);
        }
        //This is only for specification purpose, you can implement your own logic here
        //public double CalculateSalary(Employee employee)
        //{
        //    // Simple salary calculation
        //    double hra = employee.BasicSalary * 0.20;
        //    double da = employee.BasicSalary * 0.10;

        //    return employee.BasicSalary + hra + da;
        //}

        //This violates the Open/Closed Principle because if we add a new employee type, we have to modify this method. 
        //Instead, we can use polymorphism to calculate the salary based on the employee type.
        //public double CalculateSalary(Employee employee)
        //{
        //    if (employee.EmployeeType == "Permanent")
        //    {
        //        return employee.BasicSalary + (employee.BasicSalary * 0.20) + (employee.BasicSalary * 0.10);
        //    }
        //    else if (employee.EmployeeType == "Contract")
        //    {
        //        return employee.BasicSalary + (employee.BasicSalary * 0.05);
        //    }

        //    return employee.BasicSalary;
        //}
    }

    //This is for Open/Closed Principle, we can create separate classes for each employee type
    //and implement the ISalaryCalculator interface.
    public class PermanentSalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            double hra = employee.BasicSalary * 0.20;
            double da = employee.BasicSalary * 0.10;

            return employee.BasicSalary + hra + da;
        }
    }
    public class ContractSalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            double allowance = employee.BasicSalary * 0.05;

            return employee.BasicSalary + allowance;
        }
    }
    public class InternSalaryCalculator : ISalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.BasicSalary;
        }
    }
}
