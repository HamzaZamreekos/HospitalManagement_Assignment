using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Nurse : Employee
    {
        public int WorkHours { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
