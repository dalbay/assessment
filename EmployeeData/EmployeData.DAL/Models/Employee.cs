using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeData.DAL.Models
{
    public class Employee : BaseModel
    {
        public string Fname { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public Guid ProjectId { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
    }
}
