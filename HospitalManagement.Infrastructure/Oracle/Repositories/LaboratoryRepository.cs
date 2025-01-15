using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using HospitalManagement.Core.Repositories.Interfaces;
using System.Data;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
	public class LaboratoryRepository : ILaboratoryRepository
	{
		private OracleConnection _db;
		public LaboratoryRepository()
		{
			_db = new OracleConnection(Static.ConnectionString);
			_db.Open();
		}

		public DatabaseResponse<int> AddLaboratory(Laboratory laboratory)
		{
			var response = new DatabaseResponse<int>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "INSERT INTO Laboratories (Name, NumberOfRooms, WardId) " +
									  "VALUES (:Name, :NumberOfRooms, :WardId) RETURNING Id INTO :Id";
				command.Parameters.Add(new OracleParameter("Name", laboratory.Name));
				command.Parameters.Add(new OracleParameter("NumberOfRooms", laboratory.NumberOfRooms));
				command.Parameters.Add(new OracleParameter("WardId", laboratory.WardId));

				OracleParameter idParam = new OracleParameter(":Id", OracleDbType.Int32);
				idParam.Direction = ParameterDirection.Output;
				command.Parameters.Add(idParam);
				response.Success = command.ExecuteNonQuery() > 0;
				response.Data = Convert.ToInt32(idParam.Value.ToString());

				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<List<Laboratory>> GetAllLaboratories()
		{
			List<Laboratory> laboratories = new List<Laboratory>();
			var response = new DatabaseResponse<List<Laboratory>>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Laboratories";
				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						laboratories.Add(new Laboratory()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = (string)reader["Name"],
							NumberOfRooms = Convert.ToInt32(reader["NumberOfRooms"]),
							WardId = Convert.ToInt32(reader["WardId"]),
						});
					}
				}
				response.Data = laboratories;
				response.Success = true;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<Laboratory> GetLaboratory(int laboratoryId)
		{
			var response = new DatabaseResponse<Laboratory>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Laboratories WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", laboratoryId));

				using (OracleDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						var laboratory = new Laboratory()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = (string)reader["Name"],
							NumberOfRooms = Convert.ToInt32(reader["NumberOfRooms"]),
							WardId = Convert.ToInt32(reader["WardId"]),
						};
						response.Data = laboratory;
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
