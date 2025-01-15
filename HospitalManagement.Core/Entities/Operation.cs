using System;


namespace HospitalManagement.Core.Entities
{
    public class Operation
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateTime { get; set; }

        public int OperatingDoctorId { get; set; }
        public int PatientId { get; set; }

        public Doctor OperatingDoctor { get; set; }
        public Patient Patient { get; set; }

        public string OperatingDoctorName => OperatingDoctor.Name;
        public string PatientName => Patient.Name;
    }
}
