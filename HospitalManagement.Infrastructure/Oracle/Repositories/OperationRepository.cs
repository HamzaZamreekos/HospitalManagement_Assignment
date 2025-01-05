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
                command.CommandText = "INSERT INTO Operations (Name, OperatingDoctorId, Cost, DateTime) " 
                    + "VALUES (:Name, :OperatingDoctorId, :Cost, TO_DATE(:DateVar, 'YYYY-MM-DD HH24:MI:SS'))";
                command.Parameters.Add(new OracleParameter("Name", operation.Name));
                command.Parameters.Add(new OracleParameter("OperatingDoctorId", operation.OperatingDoctorId));
                command.Parameters.Add(new OracleParameter("Cost", operation.Cost));
                command.Parameters.Add(new OracleParameter("DateVar", operation.Date.ToString("yyyy-MM-dd HH:mm:ss")));
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
                command.CommandText = "select * from Operations";
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        operations.Add(new Operation() { Name = (string)reader["Name"], Date = (DateTime)reader["DateTime"], Cost = Convert.ToDecimal(reader["Cost"]), Id = Convert.ToInt32(Convert.ToString(reader["Id"])), OperatingDoctorId = Convert.ToInt32(Convert.ToString(reader["OperatingDoctorId"])) });
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
            throw new NotImplementedException();
        }
    }
}
