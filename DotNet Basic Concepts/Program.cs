using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using Basic_DotNet_Concepts.Solid_Principles.Services;
using DotNet_Basic_Concepts.Solid_Principles.Shapes;

namespace EmployeeSalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("==========================================");
            //Console.WriteLine("     EMPLOYEE SALARY CALCULATOR");
            //Console.WriteLine("==========================================");

            //// Create an Employee object
            //Employee employee = new Employee
            //{
            //    Id = 101,
            //    Name = "Sushma",
            //    Department = "IT",
            //    EmployeeType = "Permanent",
            //    BasicSalary = 50000,
            //    Email = "sushma@gmail.com"
            //};

            //// Employee Repository Service
            //EmployeeRepository employeeRepository = new EmployeeRepository();

            //employeeRepository.AddEmployee(employee);

            //Console.WriteLine();

            //employeeRepository.DisplayEmployee(employee);

            //Console.WriteLine();

            //// Salary Service
            //// Select Salary Calculator based on Employee Type
            //ISalaryCalculator salaryCalculator;

            //switch (employee.EmployeeType)
            //{
            //    case "Permanent":
            //        salaryCalculator = new PermanentSalaryCalculator();
            //        break;

            //    case "Contract":
            //        salaryCalculator = new ContractSalaryCalculator();
            //        break;

            //    case "Intern":
            //        salaryCalculator = new InternSalaryCalculator();
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Employee Type");
            //        return;
            //}

            //// Calculate Salary
            //double salary = salaryCalculator.CalculateSalary(employee);

            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine($"Net Salary : {salary}");
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine();

            //// Notification Service
            //EmailNotification notification = new EmailNotification();

            //notification.SendNotification(employee);

            //Console.WriteLine();
            //Console.WriteLine("==========================================");
            //Console.WriteLine("Process Completed Successfully.");
            //Console.WriteLine("==========================================");

            //Console.WriteLine();
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            Employee employee = new Employee
            {
                Id = 101,
                Name = "Sushma",
                Department = "IT",
                EmployeeType = "Permanent",
                BasicSalary = 50000,
                Email = "sushma@gmail.com"
            };

            // Repository
            IEmployeeRepository repository = new EmployeeRepository();

            repository.AddEmployee(employee);

            repository.DisplayEmployee(employee);

            Console.WriteLine();

            // Salary Strategy
            ISalaryCalculator calculator = new PermanentSalaryCalculator();

            SalaryService salaryService = new SalaryService(calculator);

            Console.WriteLine($"Salary : {salaryService.CalculateSalary(employee)}");

            Console.WriteLine();

            // DIP
            INotification notification = new EmailNotification();

            notification.SendNotification(employee);

            Console.WriteLine();

            // LSP
            IShape rectangle = new Rectangle
            {
                Length = 10,
                Width = 5
            };

            Console.WriteLine($"Rectangle Area : {rectangle.CalculateArea()}");

            IShape square = new Square
            {
                Side = 5
            };

            Console.WriteLine($"Square Area : {square.CalculateArea()}");

            Console.ReadKey();
        }
    }
}