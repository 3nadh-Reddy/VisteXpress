using VisitXpress.Repositories.Entities;

public interface IVisitorRepository
{
    Task<Visitor> AddVisitor(Visitor visitor);
    Task<Visitor?> GetVisitor(int id);
}
