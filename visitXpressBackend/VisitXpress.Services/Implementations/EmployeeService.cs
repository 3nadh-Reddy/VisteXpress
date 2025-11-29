using VisitXpress.Repositories.Entities;
using VisitXpress.Repositories;
using VisitXpress.Services.DTOs;
using VisitXpress.Services.Interfaces;

namespace VisitXpress.Services;

public class EmployeeService(IUnitOfWork _unitOfWork) : IEmployeeService
{
    // private readonly IUnitOfWork _unitOfWork;

    // public EmployeeService(IUnitOfWork unitOfWork)
    // {
    //     _unitOfWork = unitOfWork;
    // }

    private static EmployeeDto MapToDto(Employee e) => new()
    {
        EmployeeId = e.EmployeeId,
        FirstName = e.FirstName,
        LastName = e.LastName,
        Email = e.Email,
        Phone = e.Phone,
        IsActive = e.IsActive
    };

    public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
    {
        var employees = await _unitOfWork.Employees.GetAllAsync();
        return employees.Select(MapToDto);
    }

    public async Task<EmployeeDto?> GetEmployeeByIdAsync(int employeeId)
    {
        var employee = await _unitOfWork.Employees.GetByIdAsync(employeeId);
        return employee == null ? null : MapToDto(employee);
    }

    public async Task<EmployeeDto> CreateEmployeeAsync(CreateEmployee request)
    {
        var employee = new Employee
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Phone = request.Phone,
            IsActive = true
        };

        await _unitOfWork.Employees.AddAsync(employee);
        await _unitOfWork.CommitAsync();

        return MapToDto(employee);
    }

    public async Task<EmployeeDto?> UpdateEmployeeAsync(int employeeId, CreateEmployee request)
    {
        var employee = await _unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
            return null;

        employee.FirstName = request.FirstName;
        employee.LastName = request.LastName;
        employee.Email = request.Email;
        employee.Phone = request.Phone;

        _unitOfWork.Employees.Update(employee);
        await _unitOfWork.CommitAsync();

        return MapToDto(employee);
    }

    public async Task<bool> DeleteEmployeeAsync(int employeeId)
    {
        var employee = await _unitOfWork.Employees.GetByIdAsync(employeeId);
        if (employee == null)
            return false;
        employee.IsActive = false;
        _unitOfWork.Employees.Update(employee);
        await _unitOfWork.CommitAsync();
        return true;
    }
}
