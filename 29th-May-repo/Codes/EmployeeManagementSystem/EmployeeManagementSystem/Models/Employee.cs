using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public string Department { get; set; }

        public DateTime DateofJoining { get; set; }

        public decimal Salary {  get; set; }

    }
}