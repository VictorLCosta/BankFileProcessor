using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class FilePatternConfiguration : IEntityTypeConfiguration<FilePattern>
{
    public void Configure(EntityTypeBuilder<FilePattern> builder)
    {
        builder
            .ToTable("PR030");

        builder
            .HasKey(e => e.Id);

        builder
            .Property(e => e.Id)
            .HasColumnName("CODDESC");
    }
}
