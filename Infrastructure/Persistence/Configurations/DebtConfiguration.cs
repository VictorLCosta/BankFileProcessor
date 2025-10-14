using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class DebtConfiguration : IEntityTypeConfiguration<Debt>
{
    public void Configure(EntityTypeBuilder<Debt> builder)
    {
        builder
            .ToTable("CO002");

        builder
            .HasKey(x => new { x.CodigoEmpresa, x.NumeroContrato });

        builder
            .HasIndex(x => new { x.SituacaoDividaCobranca, x.CodigoEmpresa, x.NumeroContrato });

        builder
            .HasIndex(x => x.NumeroCarteiraCobranca);

        builder
            .HasIndex(x => x.ScoreDivida);
    }
}
