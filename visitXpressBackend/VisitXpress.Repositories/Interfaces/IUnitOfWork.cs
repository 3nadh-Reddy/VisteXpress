using VisitXpress.Repositories.Entities;
namespace VisitXpress.Repositories;

public interface IUnitOfWork : IDisposable
{
    IRepository<Visitor> Visitors { get; }
    IRepository<Employee> Employees { get; }
    IRepository<Visit> Visits { get; }
    IRepository<Attachment> Attachments { get; }
    IRepository<Badge> Badges { get; }
    IRepository<AccessArea> AccessAreas { get; }
    IRepository<VisitAccess> VisitAccesses { get; }

    Task<int> CommitAsync();
}