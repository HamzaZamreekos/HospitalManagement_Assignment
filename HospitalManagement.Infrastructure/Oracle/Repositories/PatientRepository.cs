using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private OracleConnection _db;
        public PatientRepository() 
        {
            _db = new OracleConnection(Static.ConnectionString);
            _db.Open();
        }
        public DatabaseResponse AddPatient(Patient patient)
        {
            var response = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "INSERT INTO Doctors (Name, PhoneNumber, Salary, Address, Specialization, DateTime) " + "VALUES (:Name, :PhoneNumber, :Salary, :Address, :Specialization, TO_DATE(:DateTime, 'YYYY-MM-DD HH24:MI:SS'))";
                command.Parameters.Add(new OracleParameter("Name", doctor.Name));
                command.Parameters.Add(new OracleParameter("PhoneNumber", doctor.PhoneNumber));
                command.Parameters.Add(new OracleParameter("Salary", doctor.Salary));
                command.Parameters.Add(new OracleParameter("Address", doctor.Address));
                command.Parameters.Add(new OracleParameter("Specialization", doctor.Specialization));
                command.Parameters.Add(new OracleParameter("DateTime", doctor.DateTime.ToString("yyyy-MM-dd HH:mm:ss")));
                response.Success = command.ExecuteNonQuery() > 0;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }
        }

        public DatabaseResponse<List<Patient>> GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public DatabaseResponse<Patient> GetPatients(int patientId)
        {
            throw new NotImplementedException();
        }

        public DatabaseResponse RemovePatient(int patientId)
        {
            throw new NotImplementedException();
        }
    }
}
