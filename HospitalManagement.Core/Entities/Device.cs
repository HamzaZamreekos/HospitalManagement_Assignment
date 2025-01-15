
namespace HospitalManagement.Core.Entities
{
	public class Device
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int LaboratoryId { get; set; }

		public Laboratory Laboratory { get; set; }
	}
}
