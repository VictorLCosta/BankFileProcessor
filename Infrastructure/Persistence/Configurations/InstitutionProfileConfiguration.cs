using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class InstitutionProfileConfiguration : IEntityTypeConfiguration<InstitutionProfile>
{
    public void Configure(EntityTypeBuilder<InstitutionProfile> builder)
    {
        builder
            .ToTable("PR001");

        builder
            .HasKey(builder => builder.Id);

        builder
            .Property(builder => builder.Id)
            .HasColumnName("NUMPROC");
    }
}
