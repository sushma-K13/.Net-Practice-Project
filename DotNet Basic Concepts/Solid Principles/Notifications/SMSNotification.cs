using Basic_DotNet_Concepts.Solid_Principles.Interfaces;
using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Basic_Concepts.Solid_Principles.Notifications
{
    public class SMSNotification : INotification
    {
        public void SendNotification(Employee employee)
        {
            Console.WriteLine();
            Console.WriteLine("SMS Notification");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"SMS sent to {employee.Name}");
        }
    }
}
