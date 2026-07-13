using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Services
{
    internal class EmailNotification : INotification
    {
        public void SendNotification(Employee employee)
        {
            Console.WriteLine();
            Console.WriteLine("Email Notification");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Email sent to {employee.Email}");
            Console.WriteLine($"Hello {employee.Name},");
            Console.WriteLine("Your salary has been processed successfully.");
        }
    }
}
