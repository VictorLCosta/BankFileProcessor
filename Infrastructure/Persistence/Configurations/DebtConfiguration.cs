using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class DebtConfiguration : IEntityTypeConfiguration<Debt>
{
    public void Configure(EntityTypeBuilder<Debt> builder)
    {
        builder
            .ToTable("CO002");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });

        builder
            .HasIndex(x => new { x.SituacaoDividaCobranca, x.Id.CompanyCode, x.Id.ContractNumber });

        builder
            .HasIndex(x => x.NumeroCarteiraCobranca);

        builder
            .HasIndex(x => x.ScoreDivida);
    }
}
