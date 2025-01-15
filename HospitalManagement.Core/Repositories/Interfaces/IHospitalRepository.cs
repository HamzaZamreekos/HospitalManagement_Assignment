using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IHospitalRepository
    {
		DatabaseResponse AddHospital(Hospital hospital);
		DatabaseResponse<Hospital> GetHospital(int hospitalId);
		DatabaseResponse<List<Hospital>> GetAllHospitals();


	}
}
