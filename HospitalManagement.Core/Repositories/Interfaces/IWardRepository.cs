using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IWardRepository
    {
        DatabaseResponse AddWard(Ward ward, List<int> doctorIds, List<int> nurseIds);
        DatabaseResponse<List<Ward>> GetAllWards();
        DatabaseResponse<Ward> GetWard(int wardId);
    }
}
