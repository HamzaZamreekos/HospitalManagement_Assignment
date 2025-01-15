using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using HospitalManagement.Core.Repositories.Interfaces;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
	public class HospitalRepository : IHospitalRepository
	{
		private OracleConnection _db;
		public HospitalRepository()
		{
			_db = new OracleConnection(Static.ConnectionString);
			_db.Open();
		}
		public DatabaseResponse AddHospital(Hospital hospital)
		{
			var response = new DatabaseResponse();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "INSERT INTO Hospitals (PhoneNumber, Address, ManagingDoctorId) " +
									  "VALUES (:PhoneNumber, :Address, :ManagingDoctorId)";
				command.Parameters.Add(new OracleParameter("PhoneNumber", hospital.PhoneNumber));
				command.Parameters.Add(new OracleParameter("Address", hospital.Address));
				command.Parameters.Add(new OracleParameter("ManagingDoctorId", hospital.ManagingDoctorId));
				response.Success = command.ExecuteNonQuery() > 0;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<List<Hospital>> GetAllHospitals()
		{
			List<Hospital> hospitals = new List<Hospital>();
			var response = new DatabaseResponse<List<Hospital>>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Hospitals";
				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						hospitals.Add(new Hospital()
						{
							Id = Convert.ToInt32(reader["Id"]),
							PhoneNumber = (string)reader["PhoneNumber"],
							Address = (string)reader["Address"],
							ManagingDoctorId = Convert.ToInt32(reader["ManagingDoctorId"])
						});
					}
				}
				response.Data = hospitals;
				response.Success = true;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<Hospital> GetHospital(int hospitalId)
		{
			var response = new DatabaseResponse<Hospital>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Hospitals WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", hospitalId));

				using (OracleDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						var hospital = new Hospital()
						{
							Id = Convert.ToInt32(reader["Id"]),
							PhoneNumber = (string)reader["PhoneNumber"],
							Address = (string)reader["Address"],
							ManagingDoctorId = Convert.ToInt32(reader["ManagingDoctorId"])
						};
						response.Data = hospital;
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
	}

}
