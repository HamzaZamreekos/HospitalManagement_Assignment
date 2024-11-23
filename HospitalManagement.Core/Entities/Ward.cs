using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Ward
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; } 
        public List<Laboratory> Laboratories { get; set; }
    }
}
