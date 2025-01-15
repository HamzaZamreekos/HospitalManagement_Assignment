

namespace HospitalManagement.Core.Entities
{
    public class Hospital
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public int ManagingDoctorId { get; set; }

        public Doctor ManagingDoctor { get; set; }

        public string ManagingDoctorName => ManagingDoctor.Name;
    }
}
