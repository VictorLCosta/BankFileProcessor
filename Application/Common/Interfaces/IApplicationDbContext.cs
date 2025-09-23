using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Address> Addresses { get; }
    DbSet<Asset> Assets { get; }
    DbSet<Client> Clients { get; }
    DbSet<Debt> Debts { get; }
    DbSet<Email> Emails { get; }
    DbSet<Installment> Installments { get; }
    DbSet<InstitutionProfile> InstitutionProfiles { get; }
    DbSet<Phone> Phones { get; }
    DbSet<ProcessingRoutine> ProcessingRoutines { get; }
    DbSet<Scheduling> Schedulings { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
