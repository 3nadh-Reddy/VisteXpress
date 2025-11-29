using System.ComponentModel.DataAnnotations;

namespace VisitXpress.Repositories.Entities;

public class AccessArea
{
    public int AccessAreaId { get; set; }
    [Required]
    [MaxLength(100)]
    public string AreaName { get; set; } = string.Empty;
    [MaxLength(200)]
    public string AreaDescription { get; set; } = string.Empty;
    public ICollection<VisitAccess> Visitsccesses { get; set; } = [];
}
