
namespace HospitalManagement.Core.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PatientName => Patient.Name;
        public string LaboratoryName => Laboratory.Name;

        public int PatientId { get; set; }
        public int LaboratoryId { get; set; }

        public Laboratory Laboratory { get; set; }
        public Patient Patient { get; set; }
    }
}
