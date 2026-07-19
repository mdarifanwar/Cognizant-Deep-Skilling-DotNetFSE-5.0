using EmployeeWebAPI.Filters;
using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[CustomAuthFilter]
public class EmployeeController : ControllerBase
{
    private readonly List<Employee> employees;

    public EmployeeController()
    {
        employees = GetStandardEmployeeList();
    }

    // Returns the default employee list
    private List<Employee> GetStandardEmployeeList()
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
                DateOfBirth = new DateTime(2002, 5, 10)
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
                DateOfBirth = new DateTime(2001, 10, 15)
            }
        };
    }

    //// GET: api/employee
    //[AllowAnonymous]
    //[HttpGet]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
    //public ActionResult<List<Employee>> Get()
    //{
    //    return Ok(employees);
    //}

    // GET: api/employee
    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    // GET: api/employee/standard
    [AllowAnonymous]
    [HttpGet("standard")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<Employee> GetStandard()
    {
        return Ok(employees.First());
    }

    // POST: api/employee
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return CreatedAtAction(nameof(GetStandard), new { id = employee.Id }, employee);
    }

    // PUT: api/employee/1
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Put(int id, [FromBody] Employee updatedEmployee)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        employee.Name = updatedEmployee.Name;
        employee.Salary = updatedEmployee.Salary;
        employee.Permanent = updatedEmployee.Permanent;
        employee.Department = updatedEmployee.Department;
        employee.Skills = updatedEmployee.Skills;
        employee.DateOfBirth = updatedEmployee.DateOfBirth;

        return Ok(employee);
    }
}