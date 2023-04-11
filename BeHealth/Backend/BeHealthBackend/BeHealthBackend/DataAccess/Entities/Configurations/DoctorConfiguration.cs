using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeHealthBackend.DataAccess.Entities.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasMany(d => d.Patients)
            .WithMany(p => p.Doctors)
            .UsingEntity<DoctorPatient>(
                dp => dp.HasOne(p => p.Patient)
                    .WithMany()
                    .HasForeignKey(dp => dp.PatientId),
        dp => dp.HasOne(d => d.Doctor)
                    .WithMany()
                    .HasForeignKey(dp => dp.DoctorId)
                    .OnDelete(DeleteBehavior.ClientCascade),
        dp =>
                {
                    dp.HasKey(x => new { x.PatientId, x.DoctorId });
                }
            );

        builder.Property(d => d.FirstName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(d => d.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(d => d.PhoneNumber)
            .IsRequired()
            .HasColumnType("varchar(9)");

        builder.Property(d => d.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(d => d.Created)
            .HasDefaultValueSql("getdate()");

        builder.Property(d => d.Specialist)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(d => d.Description)
            .HasMaxLength(500);

        builder.Property(d => d.Education)
            .HasMaxLength(500);

        builder.Property(d => d.Services)
            .HasMaxLength(500);

        builder.Property(p => p.PasswordHash)
            .IsRequired();
    }
}