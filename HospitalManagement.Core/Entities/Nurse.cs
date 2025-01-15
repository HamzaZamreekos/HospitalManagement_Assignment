

namespace HospitalManagement.Core.Entities
{
    public class Nurse : Employee
    {
        public int WorkHours { get; set; }
        public int WardId { get; set; }
    }
}
