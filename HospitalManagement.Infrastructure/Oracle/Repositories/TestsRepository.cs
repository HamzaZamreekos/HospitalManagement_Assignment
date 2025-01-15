using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using HospitalManagement.Core.Repositories.Interfaces;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
	public class TestsRepository
	{
		public class TestRepository : ITestsRepository
		{
			private OracleConnection _db;
			public TestRepository()
			{
				_db = new OracleConnection(Static.ConnectionString);
				_db.Open();
			}

			public DatabaseResponse AddTest(Test test)
			{
				var response = new DatabaseResponse();
				try
				{
					var command = _db.CreateCommand();
					command.CommandText = "INSERT INTO Tests (Name, PatientId, LaboratoryId) " +
										  "VALUES (:Name, :PatientId, :LaboratoryId)";
					command.Parameters.Add(new OracleParameter("Name", test.Name));
					command.Parameters.Add(new OracleParameter("PatientId", test.PatientId));
					command.Parameters.Add(new OracleParameter("LaboratoryId", test.LaboratoryId));
					response.Success = command.ExecuteNonQuery() > 0;
					return response;
				}
				catch (Exception ex)
				{
					response.Success = false;
					return response;
				}
			}

			public DatabaseResponse<List<Test>> GetAllTests()
			{
				List<Test> tests = new List<Test>();
				var response = new DatabaseResponse<List<Test>>();
				try
				{
					var command = _db.CreateCommand();
					command.CommandText = "SELECT * FROM Tests";
					using (OracleDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							tests.Add(new Test()
							{
								Id = Convert.ToInt32(reader["Id"]),
								Name = (string)reader["Name"],
								PatientId = Convert.ToInt32(reader["PatientId"]),
								LaboratoryId = Convert.ToInt32(reader["LaboratoryId"])
							});
						}
					}
					response.Data = tests;
					response.Success = true;
					return response;
				}
				catch (Exception ex)
				{
					response.Success = false;
					return response;
				}
			}

			public DatabaseResponse<Test> GetTest(int testId)
			{
				var response = new DatabaseResponse<Test>();
				try
				{
					var command = _db.CreateCommand();
					command.CommandText = "SELECT * FROM Tests WHERE Id = :Id";
					command.Parameters.Add(new OracleParameter("Id", testId));

					using (OracleDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							var test = new Test()
							{
								Id = Convert.ToInt32(reader["Id"]),
								Name = (string)reader["Name"],
								PatientId = Convert.ToInt32(reader["PatientId"]),
								LaboratoryId = Convert.ToInt32(reader["LaboratoryId"])
							};
							response.Data = test;
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
}
