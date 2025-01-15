using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
	public class DeviceRepository : IDeviceRepository
	{
		private OracleConnection _db;
		public DeviceRepository()
		{
			_db = new OracleConnection(Static.ConnectionString);
			_db.Open();
		}

		public DatabaseResponse AddDevice(Device device)
		{
			var response = new DatabaseResponse();
			try
			{
				var command = _db.CreateCommand();

				command.CommandText = "INSERT INTO Devices (Name, LaboratoryId) " +
									  "VALUES (:Name, :LaboratoryId)";
				command.Parameters.Add(new OracleParameter("Name", device.Name));
				command.Parameters.Add(new OracleParameter("LaboratoryId", device.LaboratoryId));

				response.Success = command.ExecuteNonQuery() > 0;
				return response;
			}
			catch (Exception ex)
			{
				response.Success = false;
				return response;
			}
		}

		public DatabaseResponse<List<Device>> GetAllDevices()
		{
			var response = new DatabaseResponse<List<Device>>();
			List<Device> devices = new List<Device>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = "SELECT * FROM Devices";
				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						devices.Add(new Device()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = reader["Name"].ToString(),
							LaboratoryId = Convert.ToInt32(reader["LaboratoryId"])
						});
					}
					response.Data = devices;
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

		public DatabaseResponse<Device> GetDevice(int deviceId)
		{
			var response = new DatabaseResponse<Device>();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = $"SELECT * FROM Devices WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", deviceId));

				using (OracleDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var device = new Device()
						{
							Id = Convert.ToInt32(reader["Id"]),
							Name = reader["Name"].ToString(),
							LaboratoryId = Convert.ToInt32(reader["LaboratoryId"])
						};
						response.Data = device;
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

		public DatabaseResponse RemoveDevice(int deviceId)
		{
			var result = new DatabaseResponse();
			try
			{
				var command = _db.CreateCommand();
				command.CommandText = $"DELETE FROM Devices WHERE Id = :Id";
				command.Parameters.Add(new OracleParameter("Id", deviceId));

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
