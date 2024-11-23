using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Entities
{
    public class Laboratory
    {
        public int NumberOfRooms { get; set; }
        public Ward Ward {  get; set; }
        public List<Device> Devices {  get; set; }
    }
}
