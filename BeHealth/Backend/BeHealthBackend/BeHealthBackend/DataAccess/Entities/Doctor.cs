﻿namespace BeHealthBackend.DataAccess.Entities
{
    public class Doctor : Person
    {
        public string? Specialist { get; set; }
        public string? Description { get; set; }
        public string? Education { get; set; }
        public string? Services { get; set; }
        public virtual List<Clinic> Clinics { get; set; } = new List<Clinic>();
        public virtual List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
