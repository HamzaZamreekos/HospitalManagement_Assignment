using HospitalManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Core.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        void AddPatient(Patient patient);
        void RemovePatient(int patientId);
        List<Patient> GetAllPatients();
        Patient GetPatients(int patientId);
    }
}
