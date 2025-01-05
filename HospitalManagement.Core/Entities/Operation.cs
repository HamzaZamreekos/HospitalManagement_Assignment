using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Operation
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int OperatingDoctorId { get; set; }
        public Doctor OperatingDoctor { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public string OperatingDoctorName => OperatingDoctor.Name;
    }
}
