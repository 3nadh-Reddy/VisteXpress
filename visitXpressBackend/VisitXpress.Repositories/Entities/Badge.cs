using System.ComponentModel.DataAnnotations;

namespace VisitXpress.Repositories.Entities;

public class Badge
{
    public int BadgeId { get; set; }
    [Required]
    public int VisitId { get; set; }
    [Required]
    public Visit Visit { get; set; }
    [Required]
    [MaxLength(500)]
    public string QrCode { get; set; } = string.Empty;
    public DateTime IssuedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}
