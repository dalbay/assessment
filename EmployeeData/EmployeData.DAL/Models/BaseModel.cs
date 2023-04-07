using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeData.DAL.Models
{
    public abstract class BaseModel
    {
        [Key]
        public Guid EmpId { get; set; }
    }
}
