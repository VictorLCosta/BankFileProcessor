using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder
            .ToTable("CO092");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato });

        builder
            .HasIndex(x => new { x.Logradouro, x.Cep });
    }
}
