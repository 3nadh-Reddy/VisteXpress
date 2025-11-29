using System.ComponentModel.DataAnnotations.Schema;

namespace VisitXpress.Repositories.Entities;
[NotMapped]
public abstract class BaseEntity
{
    public bool IsActive { get; set; } = true;
}
