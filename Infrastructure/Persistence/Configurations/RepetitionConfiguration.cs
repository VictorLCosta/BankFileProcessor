using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class RepetitionConfiguration : IEntityTypeConfiguration<Repetition>
{
    public void Configure(EntityTypeBuilder<Repetition> builder)
    {
        builder
            .ToTable("PR017");

        builder
            .Property(e => e.Id)
            .HasColumnName("CODREPETICAO");
    }
}
