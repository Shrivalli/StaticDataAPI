using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> emps = Employee.getEmployees();

        [HttpGet]
        public async Task<ActionResult> getAllEmps()
        {
            return Ok(emps);
        }

    }
}
