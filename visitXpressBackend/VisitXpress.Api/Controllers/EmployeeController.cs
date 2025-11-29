using Microsoft.AspNetCore.Mvc;
using VisitXpress.Services.Interfaces;
using VisitXpress.Services.DTOs;

namespace VisitXpress.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController(IEmployeeService _employeeService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _employeeService.GetAllEmployeesAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var emp = await _employeeService.GetEmployeeByIdAsync(id);
        return emp == null ? NotFound() : Ok(emp);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployee request)
    {
        var emp = await _employeeService.CreateEmployeeAsync(request);
        return CreatedAtAction(nameof(Get), new { id = emp.EmployeeId }, emp);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] CreateEmployee request)
    {
        var emp = await _employeeService.UpdateEmployeeAsync(id, request);
        return emp == null ? NotFound() : Ok(emp);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _employeeService.DeleteEmployeeAsync(id);
        return result ? Ok() : NotFound();
    }
}
