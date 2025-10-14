using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder
            .ToTable("CO001");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato });

        builder
            .HasIndex(x => new { x.CodigoEmpresa, x.NumeroContrato, x.CpfCnpj });

        builder
            .HasIndex(x => x.CpfCnpj);
    }
}
