using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IStore.Identity;

// ReSharper disable once InconsistentNaming
public class IStoreIdenitityDbContextFactory : IDesignTimeDbContextFactory<IStoreIdentityDbContext>
{
    public IStoreIdentityDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<IStoreIdentityDbContext>();
        var connectionString = configuration.GetConnectionString("IStoreConnectionString");
        builder.UseSqlServer(connectionString);
        return new IStoreIdentityDbContext(builder.Options);
    }
}