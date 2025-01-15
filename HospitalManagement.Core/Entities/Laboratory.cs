
namespace HospitalManagement.Core.Entities
{
    public class Laboratory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        public int WardId { get; set; }

        public Ward Ward {  get; set; }

        public string WardName => Ward.Name;
    }
}
