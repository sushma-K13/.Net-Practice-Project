using Basic_DotNet_Concepts.Solid_Principles.Models;
using Basic_DotNet_Concepts.Solid_Principles.Services;

namespace EmployeeSalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("     EMPLOYEE SALARY CALCULATOR");
            Console.WriteLine("==========================================");

            // Create an Employee object
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Sushma",
                Department = "IT",
                EmployeeType = "Permanent",
                BasicSalary = 50000,
                Email = "sushma@gmail.com"
            };

            // Employee Repository Service
            EmployeeRepository employeeRepository = new EmployeeRepository();

            employeeRepository.AddEmployee(employee);

            Console.WriteLine();

            employeeRepository.DisplayEmployee(employee);

            Console.WriteLine();

            // Salary Service
            SalaryService salaryService = new SalaryService();

            double netSalary = salaryService.CalculateSalary(employee);

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Net Salary : {netSalary}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();

            // Notification Service
            EmailNotification notification = new EmailNotification();

            notification.SendNotification(employee);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Process Completed Successfully.");
            Console.WriteLine("==========================================");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}