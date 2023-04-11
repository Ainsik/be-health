using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeHealthBackend.DataAccess.Entities.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.PhoneNumber)
            .IsRequired()
            .HasColumnType("varchar(9)");

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Created)
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.Pesel)
            .HasColumnType("varchar(11)");

        builder.Property(p => p.PasswordHash)
            .IsRequired();
    }
}