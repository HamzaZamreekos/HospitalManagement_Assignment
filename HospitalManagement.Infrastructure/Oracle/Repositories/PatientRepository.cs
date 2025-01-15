using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Enums;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

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

        public DatabaseResponse<decimal> GetTotalAmountPaidByPatients()
        {
            var response = new DatabaseResponse<decimal>();
            try
            {

                var command = _db.CreateCommand();

                command.CommandText = "SELECT SUM(dr.PaymentAmount) AS TotalCost " +
                                      "FROM DischargeReceipts dr " +
                                      "JOIN Patients p ON dr.PatientId = p.Id " +
                                      "WHERE p.Affliction = :Affliction " +
                                      "AND EXTRACT(YEAR FROM dr.DateTime) = :Year";

                command.Parameters.Add(new OracleParameter("Affliction", "Liver"));
                command.Parameters.Add(new OracleParameter("Year", 2024));
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["TotalCost"] is DBNull)
                        {
                            response.Data = 0;
                        }
                        else
                        {
                            response.Data = Convert.ToDecimal(reader["TotalCost"]);
                        }
                        response.Success = true;
                    }
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }


        }

        public (DatabaseResponse addReceiptResponse, DatabaseResponse updatePatientResponse) 
            DischargePatient(int patientId, decimal paymentAmount, StateAtDischarge stateAtDischarge)
		{
			var addReceiptResponse = new DatabaseResponse();
			var updatePatientResponse = new DatabaseResponse();
            try
            {

                var addReceipt = _db.CreateCommand();
                var command = _db.CreateCommand();

                command.CommandText = "INSERT INTO DischargeReceipts (DateTime, PaymentAmount, PatientId, StateAtDischarge) " +
                                      "VALUES (:DateTime, :PaymentAmount, :PatientId, :StateAtDischarge)";
                command.Parameters.Add(new OracleParameter("DateTime", DateTime.Now.AddYears(-1)));
                command.Parameters.Add(new OracleParameter("PaymentAmount", paymentAmount));
                command.Parameters.Add(new OracleParameter("PatientId", patientId));
                command.Parameters.Add(new OracleParameter("StateAtDischarge", (int)stateAtDischarge));

                addReceiptResponse.Success = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                addReceiptResponse.Success = false;
            }
            var updatePatientCommand = _db.CreateCommand();
            
            try
            {
                updatePatientCommand.CommandText = "UPDATE Patients SET Discharged = 1 WHERE Id = :Id";
			    updatePatientCommand.Parameters.Add(new OracleParameter("Id", patientId));

				updatePatientResponse.Success = updatePatientCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
				updatePatientResponse.Success = false;
			}

			return (addReceiptResponse, updatePatientResponse);
		}

		public DatabaseResponse AddPatient(Patient patient)
        {
            var response = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();
                
                command.CommandText = "INSERT INTO Patients (Name, Age, Affliction, DoctorId, NurseId, Discharged) " +
                                        "VALUES (:Name, :Age, :Affliction, :DoctorId, :NurseId, :Discharged)";
                command.Parameters.Add(new OracleParameter("Name", patient.Name));
                command.Parameters.Add(new OracleParameter("Age", patient.Age));
                command.Parameters.Add(new OracleParameter("Affliction", patient.Affliction));
                command.Parameters.Add(new OracleParameter("DoctorId", patient.DoctorId));
                command.Parameters.Add(new OracleParameter("NurseId", patient.NurseId));
                command.Parameters.Add(new OracleParameter("Discharged", '0'));

                response.Success = command.ExecuteNonQuery() > 0;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }
        }
		public DatabaseResponse<List<Patient>> GetAllPatientsWithReceipts()
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
							Name = reader["Name"].ToString(),
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
                        var patient = new Patient();
                        patient.Id = Convert.ToInt32(reader["Id"]);
                        patient.Name = reader["Name"].ToString();
                        patient.Age = Convert.ToInt32(reader["Age"]);
                        patient.Affliction = reader["Affliction"].ToString();
                        patient.DoctorId = Convert.ToInt32(reader["DoctorId"]);
                        patient.NurseId = Convert.ToInt32(reader["NurseId"]);
                        patient.Discharged = Convert.ToBoolean(reader["Discharged"]);
                        patients.Add(patient);
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
							Name = reader["Name"].ToString(),
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
