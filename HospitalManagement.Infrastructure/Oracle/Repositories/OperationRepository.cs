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
	public class OperationRepository : IOperationRepository
	{
		private OracleConnection _db;
		public OperationRepository()
		{
			_db = new OracleConnection(Static.ConnectionString);
			_db.Open();
		}

		public DatabaseResponse AddOperation(Operation operation)
		{
			var response = new DatabaseResponse();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "INSERT INTO Operations (Name,PatientId,  OperatingDoctorId, Cost, DateTime) " +
									  "VALUES (:Name, :PatientId, :OperatingDoctorId, :Cost, TO_DATE(:DateTime, 'YYYY-MM-DD HH24:MI:SS'))";
				command.Parameters.Add(new OracleParameter("Name", operation.Name));
				command.Parameters.Add(new OracleParameter("PatientId", operation.PatientId));
				command.Parameters.Add(new OracleParameter("OperatingDoctorId", operation.OperatingDoctorId));
				command.Parameters.Add(new OracleParameter("Cost", operation.Cost));
				command.Parameters.Add(new OracleParameter("DateTime", operation.DateTime.ToString("yyyy-MM-dd HH:mm:ss")));
				response.Success = command.ExecuteNonQuery() > 0;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<List<Operation>> GetAllOperations()
		{
			List<Operation> operations = new List<Operation>();
			var response = new DatabaseResponse<List<Operation>>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Operations";
				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						operations.Add(new Operation()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = (string)reader["Name"],
							PatientId = Convert.ToInt32(reader["PatientId"]),
							OperatingDoctorId = Convert.ToInt32(reader["OperatingDoctorId"]),
							Cost = Convert.ToDecimal(reader["Cost"]),
							DateTime = Convert.ToDateTime(reader["DateTime"])
						});
					}
				}
				response.Data = operations;
				response.Success = true;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<Operation> GetOperation(int operationId)
		{
			var response = new DatabaseResponse<Operation>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Operations WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", operationId));

				using (OracleDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						var operation = new Operation()
						{
							Id = Convert.ToInt32(reader["Id"]),
							PatientId = Convert.ToInt32(reader["PatientId"]),
							Name = (string)reader["Name"],
							OperatingDoctorId = Convert.ToInt32(reader["OperatingDoctorId"]),
							Cost = Convert.ToDecimal(reader["Cost"]),
							DateTime = (DateTime)reader["DateTime"]
						};
						response.Data = operation;
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
