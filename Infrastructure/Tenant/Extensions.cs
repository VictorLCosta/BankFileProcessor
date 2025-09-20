using Finbuckle.MultiTenant;

namespace Infrastructure.Tenant;

public static class Extensions
{
    public static IServiceCollection AddMultitenancy(this IServiceCollection services)
    {
        services
            .AddMultiTenant<ApplicationTenantInfo>()
            .WithConfigurationStore();

        return services;
    }
}
