
namespace HospitalManagement.Core.Entities
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfEmployees { get; set; }

        public string HospitalName => Hospital.Address;

        public int HospitalId { get; set; }
    
        public Hospital Hospital { get; set; }
    }
}
