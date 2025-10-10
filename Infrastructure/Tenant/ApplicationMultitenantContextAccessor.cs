using Finbuckle.MultiTenant;
using Finbuckle.MultiTenant.Abstractions;

namespace Infrastructure.Tenant;

public class ApplicationMultitenantContextAccessor<TTenantInfo> 
    : IMultiTenantContextAccessor<TTenantInfo> where TTenantInfo : class, ITenantInfo, new()
{
    private readonly ITenantResolver<TTenantInfo> _tenantResolver = default!;

    public ApplicationMultitenantContextAccessor(ITenantResolver<TTenantInfo> tenantResolver)
    {
        _tenantResolver = tenantResolver;

        MultiTenantContext = _tenantResolver.ResolveAsync("santander-varejo").GetAwaiter().GetResult();
    }

    public ApplicationMultitenantContextAccessor(IMultiTenantContext<TTenantInfo> multiTenantContext)
    {
        MultiTenantContext = multiTenantContext;
    }

    public IMultiTenantContext<TTenantInfo> MultiTenantContext { get; }

    IMultiTenantContext IMultiTenantContextAccessor.MultiTenantContext => MultiTenantContext;

}
