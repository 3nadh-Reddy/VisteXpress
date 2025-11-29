using VisitXpress.Repositories;
using VisitXpress.Repositories.Data;
using VisitXpress.Repositories.Entities;

public class UnitOfWork : IUnitOfWork
{
    private readonly VisitXpressDbContext _context;
    public IRepository<Visitor> Visitors { get; }
    public IRepository<Employee> Employees { get; }
    public IRepository<Visit> Visits { get; }
    public IRepository<Attachment> Attachments { get; }
    public IRepository<Badge> Badges { get; }
    public IRepository<AccessArea> AccessAreas { get; }
    public IRepository<VisitAccess> VisitAccesses { get; }

    public UnitOfWork(VisitXpressDbContext context)
    {
        _context = context;
        Visitors = new Repository<Visitor>(_context);
        Employees = new Repository<Employee>(_context);
        Visits = new Repository<Visit>(_context);
        Attachments = new Repository<Attachment>(_context);
        Badges = new Repository<Badge>(_context);
        AccessAreas = new Repository<AccessArea>(_context);
        VisitAccesses = new Repository<VisitAccess>(_context);
    }

    public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();
}
