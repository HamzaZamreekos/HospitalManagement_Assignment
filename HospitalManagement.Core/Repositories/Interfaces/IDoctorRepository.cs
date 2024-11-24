using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        bool AddDoctor(Doctor doctor);
        bool RemoveDoctor(int doctorId);
        List<Doctor> GetAllDoctors();
        Doctor GetDoctor(int doctorId);
    }
}
