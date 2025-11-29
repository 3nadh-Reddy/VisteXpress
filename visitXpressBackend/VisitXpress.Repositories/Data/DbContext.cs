using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VisitXpress.Repositories.Entities;

namespace VisitXpress.Repositories.Data;

public class VisitXpressDbContext : DbContext
{
    public VisitXpressDbContext(DbContextOptions<VisitXpressDbContext> options) : base(options) { }
    public DbSet<Visitor> Visitors { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Badge> Badges { get; set; }
    public DbSet<AccessArea> AccessAreas { get; set; }
    public DbSet<VisitAccess> VisitAccesses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VisitAccess>()
            .HasKey(x => new { x.VisitId, x.AccessAreaId });

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var clrType = entityType.ClrType;

            // Look for "IsActive" property
            var isActiveProp = entityType.FindProperty("IsActive");

            if (isActiveProp != null && isActiveProp.ClrType == typeof(bool))
            {
                // e =>
                var parameter = Expression.Parameter(clrType, "e");

                // e.IsActive
                var property = Expression.Property(parameter, "IsActive");

                // e.IsActive == true
                var filter = Expression.Lambda(
                    Expression.Equal(property, Expression.Constant(true)),
                    parameter
                );

                modelBuilder.Entity(clrType).HasQueryFilter(filter);
            }
        }
    }
}
