using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IStore.Identity;

public static class IdentityServicesRegistration
{
    public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        
        return services;
    }
}