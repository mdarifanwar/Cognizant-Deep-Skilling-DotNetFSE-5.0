using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = GetStandardEmployeeList();

    private static List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Arif",
                Salary = 50000,
                Permanent = true,
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "ASP.NET Core" }
                },
                DateOfBirth = new DateTime(2002,5,10)
            },

            new Employee
            {
                Id = 2,
                Name = "Rahul",
                Salary = 45000,
                Permanent = false,
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>
                {
                    new Skill { Id = 3, Name = "Communication" },
                    new Skill { Id = 4, Name = "Recruitment" }
                },
                DateOfBirth = new DateTime(2001,10,15)
            }
        };
    }

    // GET: api/employee
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    // GET: api/employee/1
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Employee> Get(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        return Ok(employee);
    }

    // POST: api/employee
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
    }

    // PUT: api/employee/1
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmployee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employee.Name = updatedEmployee.Name;
        employee.Salary = updatedEmployee.Salary;
        employee.Permanent = updatedEmployee.Permanent;
        employee.Department = updatedEmployee.Department;
        employee.Skills = updatedEmployee.Skills;
        employee.DateOfBirth = updatedEmployee.DateOfBirth;

        return Ok(employee);
    }

    // DELETE: api/employee/1
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Delete(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        employees.Remove(employee);

        return Ok(employee);
    }
}