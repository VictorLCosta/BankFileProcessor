using Domain.Entities;
using Finbuckle.MultiTenant.Abstractions;
using Infrastructure.Tenant;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

internal class ApplicationDbContext(IMultiTenantContextAccessor<ApplicationTenantInfo> accessor,
    DbContextOptions options) : BaseDbContext(accessor, options), IApplicationDbContext
{
    public DbSet<Address> Addresses => Set<Address>();

    public DbSet<Asset> Assets => Set<Asset>();

    public DbSet<Client> Clients => Set<Client>();

    public DbSet<Debt> Debts => Set<Debt>();

    public DbSet<Email> Emails => Set<Email>();

    public DbSet<Installment> Installments => Set<Installment>();

    public DbSet<Phone> Phones => Set<Phone>();

    public DbSet<InstitutionProfile> InstitutionProfiles => Set<InstitutionProfile>();

    public DbSet<ProcessingRoutine> ProcessingRoutines => Set<ProcessingRoutine>();

    public DbSet<Scheduling> Schedulings => Set<Scheduling>();

    async Task<int> IApplicationDbContext.SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
