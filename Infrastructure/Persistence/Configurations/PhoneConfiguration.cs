using Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder
            .ToTable("CO090");

        builder.ComplexProperty(x => x.Id, b =>
        {
            b.Property(bid => bid.CompanyCode)
                .HasColumnName("CODEMPRESA");

            b.Property(bid => bid.ContractNumber)
                .HasColumnName("NUMCONTRDIV");
        });
    }
}
