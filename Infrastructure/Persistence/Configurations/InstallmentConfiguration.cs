using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class InstallmentConfiguration : IEntityTypeConfiguration<Installment>
{
    public void Configure(EntityTypeBuilder<Installment> builder)
    {
        builder
            .ToTable("CO003");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });

        builder
            .HasIndex(x => x.SituacaoParcela);

        builder
            .HasIndex(x => new { x.DataDirecionamento, x.Id.CompanyCode });

        builder
            .HasIndex(x => x.ScoreDivida);
    }
}
