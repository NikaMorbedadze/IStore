using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IStore.Persistence;


// ReSharper disable once InconsistentNaming
public class IStoreDbContextFactory :IDesignTimeDbContextFactory<IStoreDbContext>
{
    public IStoreDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        var builder = new DbContextOptionsBuilder<IStoreDbContext>();
        var connectionString = configuration.GetConnectionString("IStoreConnectionString");
        builder.UseSqlServer(connectionString);
        return new IStoreDbContext(builder.Options);
    }
}