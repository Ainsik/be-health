using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeHealthBackend.DataAccess.Entities.Configurations;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasOne(c => c.Clinic)
            .WithOne(a => a.Address)
            .HasForeignKey<Clinic>(c => c.AddressId);

        builder.HasOne(d => d.Doctor)
            .WithOne(a => a.Address)
            .HasForeignKey<Doctor>(p => p.AddressId);

        builder.HasOne(p => p.Patient)
            .WithOne(a => a.Address)
            .HasForeignKey<Patient>(p => p.AddressId);

        builder.Property(a => a.City)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(a => a.Street)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(a => a.PostalCode)
            .IsRequired()
            .HasColumnType("varchar(6)");
    }
}