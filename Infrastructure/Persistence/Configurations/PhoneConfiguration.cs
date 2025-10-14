using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder
            .ToTable("CO090");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato, x.Numero });
    }
}
