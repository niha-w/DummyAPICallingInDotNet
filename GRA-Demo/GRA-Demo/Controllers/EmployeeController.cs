using GRA_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace GRA_Demo.Controllers
{
    [Route("/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService es = new EmployeeService();
        [HttpGet("{empId}")]
        public async Task<IActionResult> GetEmployeeById (int empId)
        {
            var emp = await es.GetEmployeeById(empId);
            return Ok(emp);
        }
    }
}
