using System.Diagnostics;
using BeHealthBackend.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeHealthBackend.DataAccess.DbContexts;

public class BeHealthContext : DbContext
{
    public BeHealthContext(DbContextOptions<BeHealthContext> options) : base(options)
    {
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Clinic> Clinics { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Referral> Referrals { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<WorkHours> WorkHours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}