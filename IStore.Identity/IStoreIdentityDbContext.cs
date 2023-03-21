using IStore.Identity.Configurations;
using IStore.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IStore.Identity;

// ReSharper disable once InconsistentNaming
public class IStoreIdentityDbContext : IdentityDbContext<ApplicationUser>
{
    public IStoreIdentityDbContext(DbContextOptions<IStoreIdentityDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
    }
}