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
                command.CommandText = "INSERT INTO Doctors (Name, OperatingDoctorId, Cost, Date) " + "VALUES (:Name, :OperatingDoctorId,:Cost , TO_DATE(:Date, 'YYYY-MM-DD HH24:MI:SS'))";
                command.Parameters.Add(new OracleParameter("Name", operation.Name));
                command.Parameters.Add(new OracleParameter("OperatingDoctorId", operation.OperatingDoctorId));
                command.Parameters.Add(new OracleParameter("Salary", doctor.Salary));
                command.Parameters.Add(new OracleParameter("Specialization", doctor.Specialization));
                command.Parameters.Add(new OracleParameter("Date", doctor.DateTime.ToString("yyyy-MM-dd HH:mm:ss")));
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
            throw new NotImplementedException();
        }

        public DatabaseResponse<Operation> GetOperation(int operationId)
        {
            throw new NotImplementedException();
        }
    }
}
