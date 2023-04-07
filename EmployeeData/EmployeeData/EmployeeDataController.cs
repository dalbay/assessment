using EmployeData.DAL;
using EmployeData.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        EmployeeDataDbContext db;

        public EmployeeDataController(EmployeeDataDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Employee> employees()
        {
            return db.Employees.ToList();
        }


    }
}
