using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace VisitXpress.Repositories.Entities;

public class Attachment
{
    public int AttachmentId { get; set; }
    [Required]
    public int VisitorId { get; set; }
    [Required]
    public required Visitor Visitor { get; set; }
    [Required]
    [MaxLength(100)]
    public string FileName { get; set; } = string.Empty;
    [Required]
    [MaxLength(500)]
    public string FileUrl { get; set; } = string.Empty;
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
    public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
    public bool isActive { get; set; } = true;
}
