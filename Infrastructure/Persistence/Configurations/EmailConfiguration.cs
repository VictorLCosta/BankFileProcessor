using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class EmailConfiguration : IEntityTypeConfiguration<Email>
{
    public void Configure(EntityTypeBuilder<Email> builder)
    {
        builder
            .ToTable("CO125");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato, x.DescricaoEmail });
    }
}
