using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
    public class NurseRepository : INurseRepository
    {
        private OracleConnection _db;
        public NurseRepository()
        {
            _db = new OracleConnection(Static.ConnectionString);
            _db.Open();
        }

        public DatabaseResponse AddNurse(Nurse nurse)
        {
            var response = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();

                command.CommandText = "INSERT INTO Nurses (Name, PhoneNumber, Salary, Address, WorkHours) " +
                                      "VALUES (:Name, :PhoneNumber, :Salary, :Address, :WorkHours)";
                command.Parameters.Add(new OracleParameter("Name", nurse.Name));
                command.Parameters.Add(new OracleParameter("PhoneNumber", nurse.PhoneNumber));
                command.Parameters.Add(new OracleParameter("Salary", nurse.Salary));
                command.Parameters.Add(new OracleParameter("Address", nurse.Address));
                command.Parameters.Add(new OracleParameter("WorkHours", nurse.WorkHours));

                response.Success = command.ExecuteNonQuery() > 0;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }
        }

        public DatabaseResponse<List<Nurse>> GetAllNurses()
        {
            var response = new DatabaseResponse<List<Nurse>>();
            List<Nurse> nurses = new List<Nurse>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "SELECT * FROM Nurses";
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nurses.Add(new Nurse()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"]),
                            Address = reader["Address"].ToString(),
                            WorkHours = Convert.ToInt32(reader["WorkHours"])
                        });
                    }
                    response.Data = nurses;
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

        public DatabaseResponse<Nurse> GetNurse(int nurseId)
        {
            var response = new DatabaseResponse<Nurse>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"SELECT * FROM Nurses WHERE Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", nurseId));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nurse = new Nurse()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"]),
                            Address = reader["Address"].ToString(),
                            WorkHours = Convert.ToInt32(reader["WorkHours"]),
                        };
                        response.Data = nurse;
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

        public DatabaseResponse RemoveNurse(int nurseId)
        {
            var result = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"DELETE FROM Nurses WHERE Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", nurseId));

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
