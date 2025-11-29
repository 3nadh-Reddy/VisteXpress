using System.ComponentModel.DataAnnotations;
using VisitXpress.Common;

namespace VisitXpress.Repositories.Entities;

public class Visit
{
    public int VisitId { get; set; }
    [Required]
    public int VisitorId { get; set; }
    [Required]
    public required Visitor Visitor { get; set; }
    [Required]
    [MaxLength(250)]
    public required string Purpose { get; set; }
    [Required]
    public int EmployeeId { get; set; }
    [Required]
    public required Employee Employee { get; set; }
    public DateTime? ExpectedArrival { get; set; }
    public DateTime? ExpectedDeparture { get; set; }
    public DateTime? ActualCheckIn { get; set; }
    public DateTime? ActualCheckOut { get; set; }
    public Badge? Badge { get; set; }
    [Required]
    public VisitStatus VisitStatus { get; set; } = VisitStatus.Pending;
    public bool isActive { get; set; } = true;
    public ICollection<Attachment> Attachments { get; set; } = [];
    public ICollection<VisitAccess> VisitAccessAreas { get; set; } = [];
}
