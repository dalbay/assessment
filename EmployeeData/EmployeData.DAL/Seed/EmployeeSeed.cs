using EmployeData.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeData.DAL.Seed
{
    public class EmployeeSeed
    {
        public static readonly List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                EmpId = Guid.NewGuid(),
                Department = "IT",


            }
        };
    }
}
