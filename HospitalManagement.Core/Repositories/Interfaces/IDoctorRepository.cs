using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System;
using System.Collections.Generic;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        DatabaseResponse AddDoctor(Doctor doctor);
        DatabaseResponse RemoveDoctor(int doctorId);
        DatabaseResponse<List<Doctor>> GetAllDoctors();
        DatabaseResponse<Doctor> GetDoctor(int doctorId);
        DatabaseResponse<(string doctorName, int operations, decimal price)> GetDoctorThatOperatedTheMost(DateTime yearToFilterBy);
    }
}
