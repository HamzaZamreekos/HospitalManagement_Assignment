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
                
                command.CommandText = "INSERT INTO Patients (Age, Affliction, DoctorId, NurseId) " +
                                        "VALUES (:Age, :Affliction, :DoctorId, :NurseId)";
                command.Parameters.Add(new OracleParameter("Age", patient.Age));
                command.Parameters.Add(new OracleParameter("Affliction", patient.Affliction));
                command.Parameters.Add(new OracleParameter("DoctorId", patient.DoctorId));
                command.Parameters.Add(new OracleParameter("NurseId", patient.NurseId));

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
            var response = new DatabaseResponse<List<Patient>>();
            List<Patient> patients = new List<Patient>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "SELECT * FROM Patients";
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(new Patient()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Age = Convert.ToInt32(reader["Age"]),
                            Affliction = reader["Affliction"].ToString(),
                            DoctorId = Convert.ToInt32(reader["DoctorId"]),
                            NurseId = Convert.ToInt32(reader["NurseId"])
                        });
                    }
                    response.Data = patients;
                    response.Success = true;
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }

        }

        public DatabaseResponse<Patient> GetPatient(int patientId)
        {
            var response = new DatabaseResponse<Patient>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"SELECT * FROM Patients WHERE Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", patientId));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var patient = new Patient()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Age = Convert.ToInt32(reader["Age"]),
                            Affliction = reader["Affliction"].ToString(),
                            DoctorId = Convert.ToInt32(reader["DoctorId"]),
                            NurseId = Convert.ToInt32(reader["NurseId"])
                        };
                        response.Data = patient;
                        response.Success = true;
                        return response;
                    }
                }
                response.Success = false;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }

        }

        public DatabaseResponse RemovePatient(int patientId)
        {
            var result = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"DELETE FROM Patients WHERE Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", patientId));

                result.Success = command.ExecuteNonQuery() > 0;
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                return result;
            }
        
        }
    }
}
