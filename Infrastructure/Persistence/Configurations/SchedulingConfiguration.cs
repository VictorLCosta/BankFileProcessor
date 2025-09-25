using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class SchedulingConfiguration : IEntityTypeConfiguration<Scheduling>
{
    public void Configure(EntityTypeBuilder<Scheduling> builder)
    {
        builder
            .ToTable("PR018");

        builder
            .HasIndex(x => x.IsActive);
    }
}
