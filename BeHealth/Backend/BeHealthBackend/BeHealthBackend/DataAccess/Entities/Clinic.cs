﻿namespace BeHealthBackend.DataAccess.Entities;

public class Clinic
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int AddressId { get; set; }
    public virtual Address Address { get; set; }
    public virtual List<Doctor> Doctors { get; set; } = new();
    public virtual List<Patient> Patients { get; set; } = new();
}