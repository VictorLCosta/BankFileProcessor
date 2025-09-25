using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder
            .ToTable("CO092");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });

        builder
            .HasIndex(x => x.CpfCnpj);

        builder
            .HasIndex(x => new { x.Id.CompanyCode, x.Id.ContractNumber, x.CpfCnpj });

        builder
            .HasIndex(x => new { x.Logradouro, x.Cep });
    }
}
