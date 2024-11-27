using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.ViewModels
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Affliction { get; set; }
        public int Doctor { get; set; }
        public int Nurse { get; set; }
    }
}
