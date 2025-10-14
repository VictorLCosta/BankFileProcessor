using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ProcessingRoutineConfiguration : IEntityTypeConfiguration<ProcessingRoutine>
{
    public void Configure(EntityTypeBuilder<ProcessingRoutine> builder)
    {
        builder
            .ToTable("PR012");

        builder.HasKey(p => p.Id);

        builder
            .Property(p => p.Id)
            .HasColumnName("CODDESC");
    }
}
