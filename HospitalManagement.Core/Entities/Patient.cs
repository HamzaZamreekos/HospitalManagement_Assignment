using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Affliction { get; set; }
        public int DoctorId { get; set; }
        public int NurseId { get; set; }
        public Doctor Doctor { get; set; }
        public Nurse Nurse { get; set; }
        public string DoctorName => Doctor.Name;
        public string NurseName => Nurse.Name;
    }
}
