using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Abstractions;

namespace Infrastructure.Tenant;

public static class Extensions
{
    public static IServiceCollection AddMultitenancy(this IServiceCollection services)
    {
        services
            .AddMultiTenant<ApplicationTenantInfo>()
            .WithConfigurationStore()
            .WithDelegateStrategy(GetTenantIdentifier);

        services.AddScoped<IMultiTenantContextAccessor<ApplicationTenantInfo>, ApplicationMultitenantContextAccessor<ApplicationTenantInfo>>();

        return services;
    }

    private static async Task<string?> GetTenantIdentifier(object context) 
    {
        return await Task.FromResult("santander-varejo");
    }

}
