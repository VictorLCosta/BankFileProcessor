using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder
            .ToTable("CO004");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });
    }
}
