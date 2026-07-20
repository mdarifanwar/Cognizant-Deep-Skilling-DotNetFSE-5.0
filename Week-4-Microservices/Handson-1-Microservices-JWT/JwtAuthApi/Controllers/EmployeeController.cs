using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<object>
            {
                new
                {
                    Id = 1,
                    Name = "Arif",
                    Department = "IT"
                },
                new
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR"
                },
                new
                {
                    Id = 3,
                    Name = "Amit",
                    Department = "Finance"
                }
            };

            return Ok(employees);
        }
    }
}