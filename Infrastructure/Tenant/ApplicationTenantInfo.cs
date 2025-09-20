using Infrastructure.Tenant.Abstractions;

namespace Infrastructure.Tenant;

internal class ApplicationTenantInfo : IApplicationTenantInfo
{
    public string? Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string? Identifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string DbProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
