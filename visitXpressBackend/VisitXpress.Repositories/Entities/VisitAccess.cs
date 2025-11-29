using System.ComponentModel.DataAnnotations;

namespace VisitXpress.Repositories.Entities;

public class VisitAccess
{
    public int VisitAccessId { get; set; }
    [Required]
    public int VisitId { get; set; }
    [Required]
    public required Visit Visit { get; set; }
    [Required]
    public int AccessAreaId { get; set; }
    [Required]
    public required AccessArea AccessArea { get; set; }
}
