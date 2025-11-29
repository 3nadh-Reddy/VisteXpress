using System.ComponentModel.DataAnnotations;

namespace VisitXpress.Repositories.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    [Required]
    [Phone]
    [MaxLength(15)]
    public string Phone { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
