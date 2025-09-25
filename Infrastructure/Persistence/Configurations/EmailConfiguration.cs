using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class EmailConfiguration : IEntityTypeConfiguration<Email>
{
    public void Configure(EntityTypeBuilder<Email> builder)
    {
        builder
            .ToTable("CO125");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });

        builder
            .HasKey(x => new { x.Id, x.DescricaoEmail });
    }
}
