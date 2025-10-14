using Finbuckle.MultiTenant.Abstractions;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Infrastructure.Tenant;
using System.Reflection;

namespace Infrastructure.Persistence;

public abstract class BaseDbContext(
    IMultiTenantContextAccessor<ApplicationTenantInfo> accessor,
    DbContextOptions options
) 
    : MultiTenantDbContext(accessor, options)
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        
        if (!string.IsNullOrWhiteSpace(accessor.MultiTenantContext?.TenantInfo?.ConnectionString)) 
        {
            optionsBuilder.ConfigureDatabase(
                accessor.MultiTenantContext.TenantInfo.DbProvider, 
                accessor.MultiTenantContext.TenantInfo.ConnectionString!
            );
        }
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        TenantNotSetMode = TenantNotSetMode.Overwrite;
        return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}
