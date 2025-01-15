using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
	public interface ITestsRepository
	{
		DatabaseResponse AddTest(Test test);
		DatabaseResponse<List<Test>> GetAllTests();
		DatabaseResponse<Test> GetTest(int testId);
	}
}
