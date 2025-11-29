using VisitXpress.Services.DTOs;

namespace VisitXpress.Services.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
    Task<EmployeeDto?> GetEmployeeByIdAsync(int employeeId);
    Task<EmployeeDto> CreateEmployeeAsync(CreateEmployee request);
    Task<EmployeeDto?> UpdateEmployeeAsync(int employeeId, CreateEmployee request);
    Task<bool> DeleteEmployeeAsync(int employeeId);
}
