using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
{
    public void Configure(EntityTypeBuilder<Installment> builder)
    {
        builder
            .ToTable("CO003");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato });

        builder
            .HasIndex(x => x.SituacaoParcela);

        builder
            .HasIndex(x => new { x.DataDirecionamento, x.CodigoEmpresa });

        builder
            .HasIndex(x => x.ScoreDivida);
    }
}
