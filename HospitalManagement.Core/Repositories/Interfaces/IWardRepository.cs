using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IWardRepository
    {
        void AddWard(Ward ward);
        void RemoveWard(int wardId);
        List<Ward> GetAllWards();
        Ward GetWard(int wardId);
    }
}
