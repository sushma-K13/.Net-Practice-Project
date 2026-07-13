using Basic_DotNet_Concepts.Solid_Principles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_DotNet_Concepts.Solid_Principles.Interfaces
{
    internal interface INotification
    {
        void SendNotification(Employee employee);
    }
}
