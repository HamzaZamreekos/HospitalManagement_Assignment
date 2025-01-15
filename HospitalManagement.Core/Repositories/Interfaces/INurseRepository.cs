using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface INurseRepository
    {
        DatabaseResponse AddNurse(Nurse nurse);
        DatabaseResponse RemoveNurse(int nurseId);
        DatabaseResponse<List<Nurse>> GetAllNurses();
        DatabaseResponse<Nurse> GetNurse(int nurseId);
    }
}
