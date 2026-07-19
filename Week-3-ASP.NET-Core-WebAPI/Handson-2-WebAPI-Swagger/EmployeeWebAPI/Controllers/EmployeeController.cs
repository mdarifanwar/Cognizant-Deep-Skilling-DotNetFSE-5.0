using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers;

[ApiController]
//[Route("api/[controller]")]
[Route("api/emp")]
public class EmployeeController : ControllerBase
{
    private static readonly List<Employee> employees = new()
    {
        new Employee
        {
            Id = 1,
            Name = "Arif",
            Department = "IT",
            Salary = 50000
        },
        new Employee
        {
            Id = 2,
            Name = "Rahul",
            Department = "HR",
            Salary = 45000
        },
        new Employee
        {
            Id = 3,
            Name = "Priya",
            Department = "Finance",
            Salary = 60000
        }
    };

    // GET: api/employee
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<Employee>> Get()
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
    public ActionResult<Employee> Post(Employee employee)
    {
        employees.Add(employee);

        return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
    }

    // PUT: api/employee/1
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Put(int id, Employee updatedEmployee)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        employee.Name = updatedEmployee.Name;
        employee.Department = updatedEmployee.Department;
        employee.Salary = updatedEmployee.Salary;

        return Ok(employee);
    }

    // DELETE: api/employee/1
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);

        if (employee == null)
            return NotFound();

        employees.Remove(employee);

        return Ok("Employee deleted successfully.");
    }
}