using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string department { get; set; }

        public string dateOfJoining { get; set; }

        public string PhotoFileName { get; set; }
    }
}