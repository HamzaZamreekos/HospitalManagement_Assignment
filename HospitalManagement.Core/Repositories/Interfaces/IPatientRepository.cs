using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        DatabaseResponse AddPatient(Patient patient);
        DatabaseResponse RemovePatient(int patientId);
        DatabaseResponse<List<Patient>> GetAllPatients();
        DatabaseResponse<Patient> GetPatient(int patientId);
    }
}
