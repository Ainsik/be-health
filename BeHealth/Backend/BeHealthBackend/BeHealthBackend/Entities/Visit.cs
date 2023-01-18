﻿namespace BeHealthBackend.Entities
{
    public class Visit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public Guid DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
