﻿using HospitalManagement.Core.Entities;
using HospitalManagement.Core.Models;
using HospitalManagement.Core.Repositories.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
namespace HospitalManagement.Infrastructure.Oracle.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private OracleConnection _db;
        public DoctorRepository() 
        {
            _db = new OracleConnection(Static.ConnectionString);
            _db.Open();

        }
        public DatabaseResponse AddDoctor(Doctor doctor)
        {
            var response = new DatabaseResponse();
            try
            {

                var command = _db.CreateCommand();
                command.CommandText = "INSERT INTO Doctors (Name, PhoneNumber, Salary, Address, Specialization, DateTime) " + "VALUES (:Name, :PhoneNumber, :Salary, :Address, :Specialization, TO_DATE(:DateTime, 'YYYY-MM-DD HH24:MI:SS'))";
                command.Parameters.Add(new OracleParameter("Name", doctor.Name));
                command.Parameters.Add(new OracleParameter("PhoneNumber", doctor.PhoneNumber)); 
                command.Parameters.Add(new OracleParameter("Salary", doctor.Salary));
                command.Parameters.Add(new OracleParameter("Address", doctor.Address));
                command.Parameters.Add(new OracleParameter("Specialization", doctor.Specialization));
                command.Parameters.Add(new OracleParameter("DateTime", doctor.DateTime.ToString("yyyy-MM-dd HH:mm:ss")));
                response.Success = command.ExecuteNonQuery() > 0;
                return response;
            }
            catch (Exception ex)
            {
                response.Success= false;
                return response;
            }
        }
        public DatabaseResponse<List<Doctor>> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            var response = new DatabaseResponse<List<Doctor>>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "select * from Doctors";
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctors.Add(new Doctor() { Name = Convert.ToString(reader["Name"]) , Address = (string)reader["Address"], DateTime= (DateTime)reader["DateTime"], PhoneNumber= (string)reader["PhoneNumber"], Salary= Convert.ToDecimal( reader["Salary"]), Specialization = (string)reader["Specialization"], Id = Convert.ToInt32(Convert.ToString(reader["Id"])) });
                    
                    }
                }
                response.Data = doctors;
                response.Success = true;
                return response;
            }
            catch(Exception ex)
            {
                response.Success=false;
                return response;
            }
        }

        public DatabaseResponse<Doctor> GetDoctor(int doctorId)
        {
            var response = new DatabaseResponse<Doctor>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"select * from Doctors where Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", doctorId));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var woah = (string)reader["Name"];
                        var woah2 = (string)reader["Address"];
                        var woah3 = (DateTime)reader["DateTime"];
                        var woah4 = Convert.ToDecimal(reader["Salary"]);
                        var doctor = new Doctor() { Name = (string)reader["Name"], Address = (string)reader["Address"], DateTime = (DateTime)reader["DateTime"], PhoneNumber = (string)reader["PhoneNumber"], Salary = Convert.ToDecimal(reader["Salary"]), Specialization = (string)reader["Specialization"], Id = Convert.ToInt32(Convert.ToString(reader["Id"])) };
                        response.Data = doctor;
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

        public DatabaseResponse<(string doctorName, int operations, decimal price)> GetDoctorThatOperatedTheMost(DateTime yearToFilterBy)
        {
            var response = new DatabaseResponse<(string doctorName, int operations, decimal price)>();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = "SELECT d.Name AS DoctorName," +
                    " COUNT(o.Id) AS OperationCount," +
                    " SUM(o.Cost) AS TotalCost FROM Operations o" +
                    " JOIN Doctors d ON o.OperatingDoctorId = d.Id" +
                    " WHERE EXTRACT(YEAR FROM o.DateTime) = :Year" +
                    " GROUP BY d.Name";
                command.Parameters.Add(new OracleParameter("Year", yearToFilterBy.Date.Year.ToString()));
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var doctorName = (string)reader["DoctorName"];
                        var totalCost = Convert.ToDecimal(reader["TotalCost"]);
                        var operationsCount = Convert.ToInt32(reader["OperationCount"]);
                        response.Success = true;
                        response.Data = (doctorName, operationsCount, totalCost);
                        return response;
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                return response;
            }
        }

        public DatabaseResponse RemoveDoctor(int doctorId)
        {
            var result = new DatabaseResponse();
            try
            {
                var command = _db.CreateCommand();
                command.CommandText = $"DELETE FROM Doctors where Id = :Id";
                command.Parameters.Add(new OracleParameter("Id", doctorId));

                result.Success = command.ExecuteNonQuery() > 0;
                return result;
            }
            catch (Exception ex)
            {
                result.Success= false;
                return result;
            }
        }
    }
}
