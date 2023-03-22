using IStore.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace IStore.Persistence;

public abstract class AuditableDbContext : DbContext
{
    public AuditableDbContext(DbContextOptions options) : base(options)
    {
    }

    public virtual async Task<int> SaveChangesAsync(string username = "SYSTEM") //TODO : გადასაკეთებელია
    {
        foreach (var entry in base.ChangeTracker.Entries<BaseDomainEntity>()
                     .Where(q => q.State is EntityState.Added or EntityState.Modified))
        {
            entry.Entity.LastModifiedDate = DateTime.Now;
            entry.Entity.LastModifiedBy = username;

            if (entry.State != EntityState.Added) continue;
            entry.Entity.DateCreated = DateTime.Now;
            entry.Entity.CreatedBy = username;
        }

        var result = await base.SaveChangesAsync();

        return result;
    }
}