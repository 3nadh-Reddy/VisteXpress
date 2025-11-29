using System.ComponentModel.DataAnnotations;
using VisitXpress.Common;

namespace VisitXpress.Repositories.Entities;

public class Visitor
{
    public int VisitorId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    [Phone]
    [MaxLength(15)]
    public string Phone { get; set; } = string.Empty;
    [Required]
    public VisitorStatus VisitorStatus = VisitorStatus.Active;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Visit> Visits { get; set; } = [];
}