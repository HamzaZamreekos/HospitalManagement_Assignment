using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
	public interface ILaboratoryRepository
	{
		DatabaseResponse<int> AddLaboratory(Laboratory laboratory);
		DatabaseResponse<List<Laboratory>> GetAllLaboratories();
		DatabaseResponse<Laboratory> GetLaboratory(int laboratoryId);
	}
}
