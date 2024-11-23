using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Doctor : Employee
    {
        public string Specialization {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
