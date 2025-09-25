using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder
            .ToTable("CO001");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });

        builder
            .HasIndex(x => x.CpfCnpj);
    }
}
