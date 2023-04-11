namespace BeHealthBackend.DataAccess.Entities;

public class Patient : Person
{
    public string Pesel { get; set; }
    public virtual List<Clinic> Clinics { get; set; } = new();
    public virtual List<Doctor> Doctors { get; set; } = new();
    public virtual Role Role { get; set; } = Role.Patient;
}