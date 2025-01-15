using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
	public class WardRepository : IWardRepository
	{
		private OracleConnection _db;
		public WardRepository()
		{
			_db = new OracleConnection(Static.ConnectionString);
			_db.Open();
		}

        public DatabaseResponse AddWard(Ward ward, List<int> doctorIds, List<int> nurseIds)
        {
            var response = new DatabaseResponse();
            try
            {
                using (var transaction = _db.BeginTransaction())
                {
                    var command = _db.CreateCommand();
                    command.Transaction = transaction;

                    // Insert Ward
                    command.CommandText = "INSERT INTO Wards (Name, PhoneNumber, NumberOfEmployees, HospitalId) " +
                                          "VALUES (:Name, :PhoneNumber, :NumberOfEmployees, :HospitalId) RETURNING Id INTO :WardId";
                    command.Parameters.Add(new OracleParameter("Name", ward.Name));
                    command.Parameters.Add(new OracleParameter("PhoneNumber", ward.PhoneNumber));
                    command.Parameters.Add(new OracleParameter("NumberOfEmployees", ward.NumberOfEmployees));
                    command.Parameters.Add(new OracleParameter("HospitalId", ward.HospitalId));
                    var wardIdParam = new OracleParameter("WardId", OracleDbType.Int32) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(wardIdParam);
                    command.ExecuteNonQuery();
                    int wardId = Convert.ToInt32(wardIdParam.Value.ToString());

                    foreach (var doctorId in doctorIds)
                    {
                        command.CommandText = "INSERT INTO WardDoctors (WardId, DoctorId) VALUES (:WardId, :DoctorId)";
                        command.Parameters.Clear();
                        command.Parameters.Add(new OracleParameter("WardId", wardId));
                        command.Parameters.Add(new OracleParameter("DoctorId", doctorId));
                        command.ExecuteNonQuery();
                    }

                    foreach (var nurseId in nurseIds)
                    {
                        command.CommandText = "INSERT INTO NursesWards (NurseId, WardId) VALUES (:NurseId, :WardId)";
                        command.Parameters.Clear();
                        command.Parameters.Add(new OracleParameter("NurseId", nurseId));
                        command.Parameters.Add(new OracleParameter("WardId", wardId));
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
            }
            return response;
        }

        public DatabaseResponse<List<Ward>> GetAllWards()
		{
			List<Ward> wards = new List<Ward>();
			var response = new DatabaseResponse<List<Ward>>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Wards";
				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						wards.Add(new Ward()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = (string)reader["Name"],
							PhoneNumber = (string)reader["PhoneNumber"],
							NumberOfEmployees = Convert.ToInt32(reader["NumberOfEmployees"]),
							HospitalId = Convert.ToInt32(reader["HospitalId"])
						});
					}
				}
				response.Data = wards;
				response.Success = true;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<Ward> GetWard(int wardId)
		{
			var response = new DatabaseResponse<Ward>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Wards WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", wardId));

				using (OracleDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						var ward = new Ward()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = (string)reader["Name"],
							PhoneNumber = (string)reader["PhoneNumber"],
							NumberOfEmployees = Convert.ToInt32(reader["NumberOfEmployees"]),
							HospitalId = Convert.ToInt32(reader["HospitalId"])
						};
						response.Data = ward;
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
