using Microsoft.EntityFrameworkCore;

namespace IStore.Persistence;

// ReSharper disable once InconsistentNaming
public class IStoreDbContext :AuditableDbContext
{
    public IStoreDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IStoreDbContext).Assembly);
    }
}