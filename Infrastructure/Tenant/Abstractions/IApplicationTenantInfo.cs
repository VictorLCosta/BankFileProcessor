using Finbuckle.MultiTenant.Abstractions;

namespace Infrastructure.Tenant.Abstractions;

public interface IApplicationTenantInfo : ITenantInfo
{
    string ConnectionString { get; set; }
    string DbProvider { get; set; }
}
