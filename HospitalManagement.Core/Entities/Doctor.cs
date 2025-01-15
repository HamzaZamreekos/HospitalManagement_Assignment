using System;
namespace HospitalManagement.Core.Entities
{
    public class Doctor : Employee
    {
        public string Specialization {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
