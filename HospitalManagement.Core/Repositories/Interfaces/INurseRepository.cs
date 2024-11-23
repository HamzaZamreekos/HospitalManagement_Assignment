using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface INurseRepository
    {
        void AddNurse(Nurse nurse);
        void RemoveNurse(int nurseId);
        List<Nurse> GetAllNurses();
        Nurse GetNurse(int nurseId);
    }
}
