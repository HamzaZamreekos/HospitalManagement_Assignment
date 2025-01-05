using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Laboratory
    {
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        public Ward Ward {  get; set; }
    }
}
